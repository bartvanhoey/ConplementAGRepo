using ConplementAG.Domain.Contacts;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ConplementAG.EntityFrameworkCore
{
    public static class ConplementAGDbContextModelCreatingExtensions
    {
        public static void ConfigureConplementAG(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(ConplementAGConsts.DbTablePrefix + "YourEntities", ConplementAGConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});


            builder.Entity<Contact>(b =>
            {
                b.ToTable(ConplementAGConsts.DbTablePrefix + "Contacts", ConplementAGConsts.DbSchema);
                b.ConfigureByConvention(); 
                

                /* Configure more properties here */
            });
        }
    }
}
