using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using BlazorEditorsWasm.Providers;
using BlazorFluentUI;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorEditorsWasm
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddBlazorFluentUI();
            builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<FileProvider>();
            builder.Services.AddSingleton<F76Manager>();

            builder.Services.AddSingleton(new FormGeneratorComponentsRepository(
                  new Dictionary<string, Type>()
                  {
                        {typeof(string).ToString(), typeof(InputText) },
                         {typeof(int).ToString(), typeof(InputText) },
                        {typeof(DateTime).ToString(), typeof(InputDate<>) },
                        {typeof(bool).ToString(), typeof(InputCheckbox) },
                        {typeof(decimal).ToString(), typeof(InputNumber<>) }
                  }, null));

            await builder.Build().RunAsync();
    
            //sdfdsdf
            //DefaultServiceProviderFacto/
        }
    }
}
