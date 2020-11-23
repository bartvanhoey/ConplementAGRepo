using System;
using Volo.Abp.Application.Dtos;

namespace ConplementAG.Domain.Contacts.Dtos
{
    [Serializable]
    public class ContactDto : FullAuditedEntityDto<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }
    }
}