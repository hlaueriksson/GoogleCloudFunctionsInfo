# GoogleCloudFunctionsInfo

[![build](https://github.com/hlaueriksson/GoogleCloudFunctionsInfo/actions/workflows/build.yml/badge.svg)](https://github.com/hlaueriksson/GoogleCloudFunctionsInfo/actions/workflows/build.yml)

> Information gathered on Google Cloud Functions by executing Google Cloud Functions

Get information about available:

* `Assemblies` and their version
* `Types` and what `Assembly` they belong to

The information gathered are from the `netcoreapp3.1` runtime version.

This project was created with [Google.Cloud.Functions.Templates](https://github.com/GoogleCloudPlatform/functions-framework-dotnet#quickstarts)

## Assemblies

> Get information about available `Assemblies` and their version

* https://us-central1-solid-antler-215713.cloudfunctions.net/GoogleCloudFunctionsInfo-Assemblies

> 95 assemblies found

```json
[
  "CloudNative.CloudEvents, Version=2.0.0.0, Culture=neutral, PublicKeyToken=eb8e1fd825734e88",
  "CloudNative.CloudEvents.SystemTextJson, Version=2.0.0.0, Culture=neutral, PublicKeyToken=eb8e1fd825734e88",
  "Google.Cloud.Functions.Framework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=185c282632e132a0",
  "Google.Cloud.Functions.Hosting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=185c282632e132a0",
  "Microsoft.AspNetCore, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.AspNetCore.Connections.Abstractions, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.AspNetCore.HostFiltering, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.AspNetCore.Hosting, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.AspNetCore.Hosting.Abstractions, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.AspNetCore.Hosting.Server.Abstractions, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.AspNetCore.Http, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.AspNetCore.Http.Abstractions, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.AspNetCore.Http.Features, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.AspNetCore.HttpOverrides, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.AspNetCore.Routing, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.AspNetCore.Routing.Abstractions, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.AspNetCore.Server.IIS, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.AspNetCore.Server.IISIntegration, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.AspNetCore.Server.Kestrel, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.AspNetCore.Server.Kestrel.Core, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.AspNetCore.WebUtilities, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.Configuration, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.Configuration.Abstractions, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.Configuration.Binder, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.Configuration.CommandLine, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.Configuration.EnvironmentVariables, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.Configuration.FileExtensions, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.Configuration.Json, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.DependencyInjection, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.DependencyInjection.Abstractions, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.FileProviders.Abstractions, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.FileProviders.Physical, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.FileSystemGlobbing, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.Hosting, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.Hosting.Abstractions, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.Logging, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.Logging.Abstractions, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.Logging.Configuration, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.Logging.Console, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.Logging.Debug, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.Logging.EventLog, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.Logging.EventSource, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.ObjectPool, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.Options, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.Options.ConfigurationExtensions, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Extensions.Primitives, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Net.Http.Headers, Version=3.1.15.0, Culture=neutral, PublicKeyToken=adb9793829ddae60",
  "Microsoft.Win32.Primitives, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "netstandard, Version=2.1.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
  "System.Buffers, Version=4.0.5.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
  "System.Collections, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Collections.Concurrent, Version=4.0.15.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Collections.Specialized, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.ComponentModel, Version=4.0.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.ComponentModel.Primitives, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.ComponentModel.TypeConverter, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Console, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Diagnostics.Debug, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Diagnostics.DiagnosticSource, Version=4.0.5.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
  "System.Diagnostics.Tracing, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Drawing.Primitives, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.IO.FileSystem, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.IO.FileSystem.Watcher, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.IO.Pipelines, Version=4.0.2.3, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
  "System.Linq, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Memory, Version=4.2.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
  "System.Net.Mail, Version=4.0.2.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
  "System.Net.Primitives, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Net.Sockets, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Net.WebSockets, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Numerics.Vectors, Version=4.1.6.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.ObjectModel, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e",
  "System.Private.Uri, Version=4.0.6.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Reflection.Emit.ILGeneration, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Reflection.Emit.Lightweight, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Reflection.Primitives, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Resources.ResourceManager, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Runtime, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Runtime.CompilerServices.Unsafe, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Runtime.Extensions, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Runtime.InteropServices, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Runtime.InteropServices.RuntimeInformation, Version=4.0.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Runtime.Intrinsics, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
  "System.Security.Claims, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Security.Cryptography.X509Certificates, Version=4.2.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Text.Encoding.Extensions, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Text.Encodings.Web, Version=5.0.0.1, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
  "System.Text.Json, Version=5.0.0.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd51",
  "System.Threading, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Threading.Tasks, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Threading.Thread, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Threading.ThreadPool, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a",
  "System.Threading.Timer, Version=4.1.2.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
]
```

## Type

> Get information about available `Types` and what `Assembly` they belong to

### FullName

Query by:

> The fully qualified name of the type, including its namespace but not its assembly

* https://us-central1-solid-antler-215713.cloudfunctions.net/GoogleCloudFunctionsInfo-TypeType?FullName={FullName}

Example: https://us-central1-solid-antler-215713.cloudfunctions.net/GoogleCloudFunctionsInfo-Type?FullName=Google.Cloud.Functions.Hosting.FunctionsStartup

> Google.Cloud.Functions.Hosting.FunctionsStartup was found in 1 assemblies

```json
[
  "Google.Cloud.Functions.Hosting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=185c282632e132a0"
]
```

### Name

Query by:

> The simple name of the type

* https://us-central1-solid-antler-215713.cloudfunctions.net/GoogleCloudFunctionsInfo-Type?Name={Name}

Example: https://us-central1-solid-antler-215713.cloudfunctions.net/GoogleCloudFunctionsInfo-Type?Name=IHttpFunction

> IHttpFunction matched 1 types

```json
[
  {
    "Type": "Google.Cloud.Functions.Framework.IHttpFunction",
    "Assembly": "Google.Cloud.Functions.Framework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=185c282632e132a0"
  }
]
```
