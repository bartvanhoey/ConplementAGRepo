using System;
using System.Threading.Tasks;
using ConplementAG.Domain.Contacts;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace ConplementAG.EntityFrameworkCore.Domain.Contacts
{
    public class ContactRepositoryTests : ConplementAGEntityFrameworkCoreTestBase
    {
        private readonly IContactRepository _contactRepository;

        public ContactRepositoryTests()
        {
            _contactRepository = GetRequiredService<IContactRepository>();
        }

        /*
        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
        */
    }
}
