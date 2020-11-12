using System.Threading.Tasks;

namespace ConplementAG.Data
{
    public interface IConplementAGDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
