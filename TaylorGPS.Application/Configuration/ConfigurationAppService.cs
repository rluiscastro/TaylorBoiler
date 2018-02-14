using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TaylorGPS.Configuration.Dto;

namespace TaylorGPS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TaylorGPSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
