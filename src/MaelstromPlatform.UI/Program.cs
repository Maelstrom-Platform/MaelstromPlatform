using MaelstromPlatform.UI;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<DialogService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://api.maelstromplatform-dev.org") });

await builder.Build().RunAsync();
