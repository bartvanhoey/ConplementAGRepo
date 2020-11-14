using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ConplementAG.Localization;
using ConplementAG.Permissions;
using Volo.Abp.Account.Localization;
using Volo.Abp.UI.Navigation;
using Volo.Abp.Users;

namespace ConplementAG.Blazor
{
  public class ConplementAGMenuContributor : IMenuContributor
  {
    private readonly IConfiguration _configuration;

    public ConplementAGMenuContributor(IConfiguration configuration)
    {
      _configuration = configuration;
    }

    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
      if (context.Menu.Name == StandardMenus.Main)
      {
        await ConfigureMainMenuAsync(context);
      }
      else if (context.Menu.Name == StandardMenus.User)
      {
        await ConfigureUserMenuAsync(context);
      }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {

      // TODO 1. Uncomment this  
      // if (context.Menu.DisplayName != StandardMenus.Main) return;

      var l = context.GetLocalizer<ConplementAGResource>();

      context.Menu.Items.Insert(
          0,
          new ApplicationMenuItem(
              "ConplementAG.Home",
              l["Menu:Home"],
              "/",
              icon: "fas fa-home"
          )
      );

      var contactManagementMenu = new ApplicationMenuItem("ContactManagementMenu", l["Menu:ContactManagement"], icon: "fas fa-users");
      context.Menu.AddItem(contactManagementMenu);

      // TODO 2. Comment out these 2 lines of code
      var ContactsMenu = new ApplicationMenuItem("ContactsMenu", l["Menu:Contacts"], url: "/contacts");
      contactManagementMenu.AddItem(ContactsMenu);

      // TODO 3. Uncomment this block of coke
      //   if (await context.IsGrantedAsync(ConplementAGPermissions.Contact.Default))
      //   {
      //     var ContactsMenu = new ApplicationMenuItem("ContactsMenu", l["Menu:Contacts"], url: "/Contacts");
      //     contactManagementMenu.AddItem(ContactsMenu);
      //   }


      // TODO 4. Comment out the line below
      return Task.CompletedTask;


    }

    private Task ConfigureUserMenuAsync(MenuConfigurationContext context)
    {
      var accountStringLocalizer = context.GetLocalizer<AccountResource>();
      var currentUser = context.ServiceProvider.GetRequiredService<ICurrentUser>();

      var identityServerUrl = _configuration["AuthServer:Authority"] ?? "";

      if (currentUser.IsAuthenticated)
      {
        context.Menu.AddItem(new ApplicationMenuItem(
            "Account.Manage",
            accountStringLocalizer["ManageYourProfile"],
            $"{identityServerUrl.EnsureEndsWith('/')}Account/Manage",
            icon: "fa fa-cog",
            order: 1000,
            null,
            "_blank"));
      }

      return Task.CompletedTask;
    }
  }
}
