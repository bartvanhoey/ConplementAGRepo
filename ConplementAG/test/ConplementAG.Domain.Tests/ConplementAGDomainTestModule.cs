using ConplementAG.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ConplementAG
{
    [DependsOn(
        typeof(ConplementAGEntityFrameworkCoreTestModule)
        )]
    public class ConplementAGDomainTestModule : AbpModule
    {

    }
}