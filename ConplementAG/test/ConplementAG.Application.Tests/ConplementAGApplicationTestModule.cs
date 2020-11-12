using Volo.Abp.Modularity;

namespace ConplementAG
{
    [DependsOn(
        typeof(ConplementAGApplicationModule),
        typeof(ConplementAGDomainTestModule)
        )]
    public class ConplementAGApplicationTestModule : AbpModule
    {

    }
}