using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Google.Cloud.Functions.Framework;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace GoogleCloudFunctionsInfo
{
    public class Type : IHttpFunction
    {
        private readonly ILogger _logger;

        public Type(ILogger<Type> logger) => _logger = logger;

        public Task HandleAsync(HttpContext context)
        {
            var fullName = context.Request.Query.FirstOrDefault(q => string.Compare(q.Key, "FullName", StringComparison.OrdinalIgnoreCase) == 0).Value;
            var name = context.Request.Query.FirstOrDefault(q => string.Compare(q.Key, "Name", StringComparison.OrdinalIgnoreCase) == 0).Value;

            if (!string.IsNullOrEmpty(fullName)) return ByFullName(context, fullName);

            if (!string.IsNullOrEmpty(name)) return ByName(context, name);

            return context.ToResponse(StatusCodes.Status400BadRequest);
        }

        private Task ByFullName(HttpContext context, string fullName)
        {
            var result = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .SkipExceptions()
                .Where(x => x.FullName == fullName)
                .OrderBy(x => x.Assembly.FullName)
                .Select(x => x.Assembly.ToString())
                .ToList();

            _logger.LogInformation($"{fullName} was found in {result.Count} assemblies");

            if (result.Any()) return context.ToOkResponse(result);

            return context.ToResponse(StatusCodes.Status404NotFound);
        }

        private Task ByName(HttpContext context, string name)
        {
            var result = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .SkipExceptions()
                .Where(x => x.Name == name)
                .OrderBy(x => x.Assembly.FullName)
                .Select(x => new { Type = x.FullName, Assembly = x.Assembly.ToString() })
                .ToList();

            _logger.LogInformation($"{name} matched {result.Count} types");

            if (result.Any()) return context.ToOkResponse(result);

            return context.ToResponse(StatusCodes.Status404NotFound);
        }
    }

    internal static class Extensions
    {
        private static readonly JsonSerializerOptions Options = new JsonSerializerOptions { WriteIndented = true };

        internal static Task ToOkResponse(this HttpContext context, object result)
        {
            context.Response.ContentType = "text/json";
            return JsonSerializer.SerializeAsync(context.Response.Body, result, Options);
        }

        internal static Task ToResponse(this HttpContext context, int statusCode)
        {
            context.Response.StatusCode = statusCode;
            return Task.CompletedTask;
        }

        internal static IEnumerable<T> SkipExceptions<T>(this IEnumerable<T> values)
        {
            using var enumerator = values.GetEnumerator();
            var next = true;
            while (next)
            {
                try
                {
                    next = enumerator.MoveNext();
                }
                catch
                {
                    continue;
                }

                if (next) yield return enumerator.Current;
            }
        }
    }
}