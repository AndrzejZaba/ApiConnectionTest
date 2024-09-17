using ApiConnectionTest.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

var uri = new Uri(builder.HostEnvironment.BaseAddress);

builder.Services.AddClient(uri);

await builder.Build().RunAsync();
