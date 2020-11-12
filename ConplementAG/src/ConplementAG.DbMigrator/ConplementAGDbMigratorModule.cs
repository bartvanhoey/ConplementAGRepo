using ConplementAG.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ConplementAG.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ConplementAGEntityFrameworkCoreDbMigrationsModule),
        typeof(ConplementAGApplicationContractsModule)
        )]
    public class ConplementAGDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
