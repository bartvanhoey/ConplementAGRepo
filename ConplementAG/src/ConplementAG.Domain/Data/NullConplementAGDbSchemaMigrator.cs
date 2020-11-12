using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ConplementAG.Data
{
    /* This is used if database provider does't define
     * IConplementAGDbSchemaMigrator implementation.
     */
    public class NullConplementAGDbSchemaMigrator : IConplementAGDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}