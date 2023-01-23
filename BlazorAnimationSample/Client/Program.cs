using BlazorAnimationSample;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

namespace BlazorAnimationSample
{
    public class Program
    {
        // OTkxNDUwQDMyMzAyZTM0MmUzMFQxb3A4YzE0NGttU1hleVM5ci9iNUtLS2lPR0JFa1pBdEhNYmdyU1YvVFE9

        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("OTkxNDUwQDMyMzAyZTM0MmUzMFQxb3A4YzE0NGttU1hleVM5ci9iNUtLS2lPR0JFa1pBdEhNYmdyU1YvVFE9");

            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSyncfusionBlazor();

            await builder.Build().RunAsync();
        }
    }
}