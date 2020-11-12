using ConplementAG.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ConplementAG.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ConplementAGController : AbpController
    {
        protected ConplementAGController()
        {
            LocalizationResource = typeof(ConplementAGResource);
        }
    }
}