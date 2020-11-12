using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace ConplementAG.EntityFrameworkCore
{
    [DependsOn(
        typeof(ConplementAGEntityFrameworkCoreModule)
        )]
    public class ConplementAGEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ConplementAGMigrationsDbContext>();
        }
    }
}
