using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace ConplementAG.Domain.Contacts
{
  
  public class Contact  : FullAuditedAggregateRoot<Guid>
  {
      public string FirstName { get; set; }
  
      public string LastName { get; set; }
  
      public string EmailAddress { get; set; }
  
      public string PhoneNumber { get; set; }
  
  }


   // TODO 1. Run AbpHelper tool to generate CRUD infrastructure

   // TODO 2. Open a terminal in the DbMigrations Project and run command below (Select command + hit F1)
   // dotnet ef migrations add Contact_Added

}