// using System.Threading.Tasks;
// using ConplementAG.Domain.Domain;
// using GenFu;
// using Volo.Abp.Data;
// using Volo.Abp.DependencyInjection;
// using Volo.Abp.Guids;

// namespace AgConplement.Domain
// {
//   public class ConplementAgDataSeedContributor : IDataSeedContributor, ITransientDependency
//   {
//     private readonly IContactRepository _contactRepository;
//     private readonly IGuidGenerator _guidGenerator;

//     public ConplementAgDataSeedContributor(IContactRepository contactRepository, IGuidGenerator guidGenerator)
//     {
//       _contactRepository = contactRepository;
//       _guidGenerator = guidGenerator;
//     }

//     public async Task SeedAsync(DataSeedContext context)
//     {
//       if (await _contactRepository.GetCountAsync() <= 0)
//       {
//         var people = A.ListOf<ContactPerson>();
//         foreach (var person in people)
//         {
//           await _contactRepository.InsertAsync(new Contact(_guidGenerator.Create(), person.FirstName, person.LastName, person.EmailAddress, person.PhoneNumber));
//         }
//       }
//     }
//   }

//   public class ContactPerson
//   {
//     public string FirstName { get; set; }

//     public string LastName { get; set; }

//     public string EmailAddress { get; set; }

//     public string PhoneNumber { get; set; }
//   }

// }