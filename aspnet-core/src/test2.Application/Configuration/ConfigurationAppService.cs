using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using test2.Configuration.Dto;

namespace test2.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : test2AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
