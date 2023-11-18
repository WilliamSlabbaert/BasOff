using _01BasOffDL.Context;
using _02BasOffBL.Services.Interfaces;
using _02BasOffBL.Services;
using _02BasOffBL.Repo;
using _01BasOffDL.Repo;
using _01BasOffEL.Entities;

namespace _03BasOffAPI.ServiceRegistry
{
    internal static class RepoRegistry
    {
        internal static void RegisterRepo(IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepo<>), typeof(GenericRepo<>));
            services.AddScoped<ILoginRepo, LoginRepo>();
        }
    }
}
