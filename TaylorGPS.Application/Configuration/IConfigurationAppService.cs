using System.Threading.Tasks;
using Abp.Application.Services;
using TaylorGPS.Configuration.Dto;

namespace TaylorGPS.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}