using System;
using ConplementAG.Domain.Contacts.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace ConplementAG.Domain.Contacts
{
    public interface IContactAppService :
        ICrudAppService< 
            ContactDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateContactDto,
            UpdateContactDto>
    {

    }
}