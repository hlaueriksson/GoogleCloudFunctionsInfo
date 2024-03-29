using Google.Cloud.Functions.Framework;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace GoogleCloudFunctionsInfo;

public class Types : IHttpFunction
{
    private readonly ILogger _logger;

    public Types(ILogger<Types> logger) => _logger = logger;

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

        _logger.LogInformation("{FullName} was found in {Count} assemblies", fullName, result.Count);

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

        _logger.LogInformation("{Name} matched {Count} types", name, result.Count);

        if (result.Any()) return context.ToOkResponse(result);

        return context.ToResponse(StatusCodes.Status404NotFound);
    }
}

internal static class Extensions
{
    private static readonly JsonSerializerOptions Options = new() { WriteIndented = true };

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
