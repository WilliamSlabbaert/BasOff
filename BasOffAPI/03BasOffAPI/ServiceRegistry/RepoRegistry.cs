using _01BasOffDL.Context;
using _02BasOffBL.Services.Interfaces;
using _02BasOffBL.Services;
using _02BasOffBL.Repo;
using _01BasOffDL.Repo;

namespace _03BasOffAPI.ServiceRegistry
{
    internal static class RepoRegistry
    {
        internal static void RegisterRepo(IServiceCollection services)
        {
            services.AddScoped<ILoginRepo, LoginRepo>();
        }
    }
}
