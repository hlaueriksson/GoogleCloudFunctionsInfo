using Google.Cloud.Functions.Framework;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace GoogleCloudFunctionsInfo;

public class Assemblies : IHttpFunction
{
    private static readonly JsonSerializerOptions Options = new() { WriteIndented = true };
    private readonly ILogger _logger;

    public Assemblies(ILogger<Assemblies> logger) => _logger = logger;

    public async Task HandleAsync(HttpContext context)
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        var result = assemblies.Except(new[] { typeof(Assemblies).Assembly }).OrderBy(x => x.FullName).Select(x => x.ToString()).ToList();

        _logger.LogInformation("{Length} assemblies found", assemblies.Length);

        context.Response.ContentType = "text/json";
        await JsonSerializer.SerializeAsync(context.Response.Body, result, Options);
    }
}
