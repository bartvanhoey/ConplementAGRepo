using System;
using ConplementAG.Permissions;
using ConplementAG.Domain.Contacts.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ConplementAG.Domain.Contacts
{
    public class ContactAppService : CrudAppService<Contact, ContactDto, Guid, PagedAndSortedResultRequestDto, CreateContactDto, UpdateContactDto>,
        IContactAppService
    {
        protected override string GetPolicyName { get; set; } = ConplementAGPermissions.Contact.Default;
        protected override string GetListPolicyName { get; set; } = ConplementAGPermissions.Contact.Default;
        protected override string CreatePolicyName { get; set; } = ConplementAGPermissions.Contact.Create;
        protected override string UpdatePolicyName { get; set; } = ConplementAGPermissions.Contact.Update;
        protected override string DeletePolicyName { get; set; } = ConplementAGPermissions.Contact.Delete;

        private readonly IContactRepository _repository;
        
        public ContactAppService(IContactRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
