using System;
using ConplementAG.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace ConplementAG.Domain.Contacts
{
    public class ContactRepository : EfCoreRepository<ConplementAGDbContext, Contact, Guid>, IContactRepository
    {
        public ContactRepository(IDbContextProvider<ConplementAGDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}