using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Rasadnik.Client.Services;
using Rasadnik.Shared;
using Rasadnik.Shared.Services;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Rasadnik.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            //builder.RootComponents.Add<App>("#app");
            
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddScoped<IPlantFamilyService, PlantFamilyService>();
            builder.Services.AddScoped<IPlantService, PlantService>();
            builder.Services.AddScoped<IPrerendering, Prerendering>();

            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<CustomAuthStateProvider>();
            builder.Services.AddScoped<AuthenticationStateProvider>(s => s.GetRequiredService<CustomAuthStateProvider>());
            builder.Services.AddScoped<IAuthService, AuthenticationService>();

            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddScoped<UserLocalStorage>();

            await builder.Build().RunAsync();
        }
    }
}
