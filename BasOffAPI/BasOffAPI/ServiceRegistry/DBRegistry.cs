using _01BasOffDL.Context;

namespace _03BasOffAPI.ServiceRegistry
{
    internal static class DBRegistry
    {
        internal static void RegisterDB(IServiceCollection services)
        {
            services.AddDbContext<MyDBContext>(ServiceLifetime.Singleton);
        }
    }
}
