using System.Globalization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;

namespace Abp.BootstrapTheme.Blazor.Host
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            var application = builder.AddApplication<BootstrapThemeBlazorHostModule>(options =>
            {
                options.UseAutofac();
            });

            var host = builder.Build();

            await application.InitializeAsync(host.Services);
            await GetCultureAsync(host);
            await host.RunAsync();
        }


        // based on https://github.com/pranavkm/LocSample
        private static async Task GetCultureAsync(WebAssemblyHost host)
        {
            var jsInterop = host.Services.GetRequiredService<IJSRuntime>();
            var result = await jsInterop.InvokeAsync<string>("cultureInfo.get") ?? CultureInfo.CurrentCulture.Name; 
            if (result != null)
            {
                // Set the culture from culture switcher
                var culture = new CultureInfo(result);
                CultureInfo.DefaultThreadCurrentCulture = culture;
                CultureInfo.DefaultThreadCurrentUICulture = culture;
            }
           
        }
    }
}
