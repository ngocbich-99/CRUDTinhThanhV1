using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace test2.Controllers
{
    public abstract class test2ControllerBase: AbpController
    {
        protected test2ControllerBase()
        {
            LocalizationSourceName = test2Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
