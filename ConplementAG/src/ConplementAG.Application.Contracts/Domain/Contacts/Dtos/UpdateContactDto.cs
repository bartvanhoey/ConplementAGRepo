using System;
using System.ComponentModel;

namespace ConplementAG.Domain.Contacts.Dtos
{
    [Serializable]
    public class UpdateContactDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }
    }
}