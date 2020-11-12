using System;
using System.Collections.Generic;
using System.Text;
using ConplementAG.Localization;
using Volo.Abp.Application.Services;

namespace ConplementAG
{
    /* Inherit your application services from this class.
     */
    public abstract class ConplementAGAppService : ApplicationService
    {
        protected ConplementAGAppService()
        {
            LocalizationResource = typeof(ConplementAGResource);
        }
    }
}
