using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace ConplementAG.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(ConplementAGHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ConplementAGConsoleApiClientModule : AbpModule
    {
        
    }
}
