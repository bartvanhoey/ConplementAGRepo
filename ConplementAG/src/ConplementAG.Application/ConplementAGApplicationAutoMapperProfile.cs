using ConplementAG.Domain.Contacts;
using ConplementAG.Domain.Contacts.Dtos;
using AutoMapper;

namespace ConplementAG
{
    public class ConplementAGApplicationAutoMapperProfile : Profile
    {
        public ConplementAGApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Contact, ContactDto>();
            CreateMap<CreateContactDto, Contact>(MemberList.Source);
            CreateMap<UpdateContactDto, Contact>(MemberList.Source);
        }
    }
}
