using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ConplementAG.Data;
using Volo.Abp.DependencyInjection;

namespace ConplementAG.EntityFrameworkCore
{
    public class EntityFrameworkCoreConplementAGDbSchemaMigrator
        : IConplementAGDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreConplementAGDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ConplementAGMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ConplementAGMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}