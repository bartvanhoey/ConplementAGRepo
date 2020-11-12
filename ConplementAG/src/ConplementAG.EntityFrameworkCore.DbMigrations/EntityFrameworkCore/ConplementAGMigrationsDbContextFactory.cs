using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ConplementAG.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class ConplementAGMigrationsDbContextFactory : IDesignTimeDbContextFactory<ConplementAGMigrationsDbContext>
    {
        public ConplementAGMigrationsDbContext CreateDbContext(string[] args)
        {
            ConplementAGEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ConplementAGMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new ConplementAGMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ConplementAG.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
