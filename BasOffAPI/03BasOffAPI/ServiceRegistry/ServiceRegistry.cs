using _02BasOffBL.Services;
using _02BasOffBL.Services.Interfaces;

namespace _03BasOffAPI.ServiceRegistry
{
    internal static class ServiceRegistry
    {
        internal static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<ILoginService, LoginService>();
        }
    }
}
