using System;
using Volo.Abp.Domain.Repositories;

namespace ConplementAG.Domain.Contacts
{
    public interface IContactRepository : IRepository<Contact, Guid>
    {
    }
}