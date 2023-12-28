# GoogleCloudFunctionsInfo

[![build](https://github.com/hlaueriksson/GoogleCloudFunctionsInfo/actions/workflows/build.yml/badge.svg)](https://github.com/hlaueriksson/GoogleCloudFunctionsInfo/actions/workflows/build.yml)

> Information gathered on Google Cloud Functions by executing Google Cloud Functions

Get information about available:

* `Assemblies` and their version
* `Types` and what `Assembly` they belong to

The information gathered are from the `net6.0` runtime version.

This project was created with [Google.Cloud.Functions.Templates](https://github.com/GoogleCloudPlatform/functions-framework-dotnet#quickstarts)

## Assemblies

> Get information about available `Assemblies` and their version

* https://us-central1-solid-antler-215713.cloudfunctions.net/GoogleCloudFunctionsInfo-Assemblies

```json
[
    "CloudNative.CloudEvents, Version=2.6.0.0, Culture=neutral, PublicKeyToken=eb8e1fd825734e88",
    "CloudNative.CloudEvents.SystemTextJson, Version=2.6.0.0, Culture=neutral, PublicKeyToken=eb8e1fd825734e88",
    "Google.Cloud.Functions.Framework, Version=2.1.0.0, Culture=neutral, PublicKeyToken=185c282632e132a0",
    "Google.Cloud.Functions.Hosting, Version=2.1.0.0, Culture=neutral, PublicKeyToken=185c282632e132a0",
    "Microsoft.AspNetCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Connections.Abstractions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.HostFiltering, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Hosting, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Hosting.Abstractions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Hosting.Server.Abstractions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Http, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Http.Abstractions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Http.Features, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.HttpOverrides, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Routing, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Routing.Abstractions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Server.IIS, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Server.IISIntegration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Server.Kestrel, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Server.Kestrel.Core, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Server.Kestrel.Transport.Quic, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.AspNetCore.WebUtilities, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Configuration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Configuration.Abstractions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Configuration.Binder, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Configuration.CommandLine, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Configuration.EnvironmentVariables, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Configuration.FileExtensions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Configuration.Json, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.DependencyInjection, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.DependencyInjection.Abstractions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Features, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.FileProviders.Abstractions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.FileProviders.Physical, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.FileSystemGlobbing, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Hosting, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Hosting.Abstractions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Logging, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Logging.Abstractions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Logging.Configuration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Logging.Console, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Logging.Debug, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Logging.EventLog, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Logging.EventSource, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.ObjectPool, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Options, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Options.ConfigurationExtensions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Extensions.Primitives, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Net.Http.Headers, Version=6.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
    "Microsoft.Win32.Primitives, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "netstandard, Version=2.1.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Collections, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Collections.Concurrent, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.ComponentModel, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.ComponentModel.Primitives, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.ComponentModel.TypeConverter, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Console, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Diagnostics.DiagnosticSource, Version=6.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Diagnostics.Tracing, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.IO.FileSystem.Watcher, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.IO.Pipelines, Version=6.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Linq, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Memory, Version=6.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Net.Mail, Version=6.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Net.Primitives, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Net.Quic, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Net.Security, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Net.Sockets, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Net.WebSockets, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Numerics.Vectors, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.ObjectModel, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e",
    "System.Private.Uri, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Reflection.Emit.ILGeneration, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Reflection.Emit.Lightweight, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Reflection.Primitives, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.CompilerServices.Unsafe, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.InteropServices, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.InteropServices.RuntimeInformation, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Runtime.Intrinsics, Version=6.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Security.Claims, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Security.Cryptography.Primitives, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Security.Cryptography.X509Certificates, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Text.Encoding.Extensions, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Text.Encodings.Web, Version=6.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Text.Json, Version=6.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
    "System.Threading, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Threading.Thread, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
    "System.Threading.ThreadPool, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
]
```

## Types

> Get information about available `Types` and what `Assembly` they belong to

### FullName

Query by:

> The fully qualified name of the type, including its namespace but not its assembly

* https://us-central1-solid-antler-215713.cloudfunctions.net/GoogleCloudFunctionsInfo-Types?FullName=Google.Cloud.Functions.Hosting.FunctionsStartup

```json
[
    "Google.Cloud.Functions.Hosting, Version=2.1.0.0, Culture=neutral, PublicKeyToken=185c282632e132a0"
]
```

### Name

Query by:

> The simple name of the type

* https://us-central1-solid-antler-215713.cloudfunctions.net/GoogleCloudFunctionsInfo-Types?Name=IHttpFunction

```json
[
    {
        "Type": "Google.Cloud.Functions.Framework.IHttpFunction",
        "Assembly": "Google.Cloud.Functions.Framework, Version=2.1.0.0, Culture=neutral, PublicKeyToken=185c282632e132a0"
    }
]
```
