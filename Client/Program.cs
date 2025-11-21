using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

String enderecoDoServidorApi = "https://localhost:7170";

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(enderecoDoServidorApi) });

await builder.Build().RunAsync();
