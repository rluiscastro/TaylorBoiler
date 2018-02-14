using System.Threading.Tasks;
using Abp.Application.Services;
using TaylorGPS.Authorization.Accounts.Dto;

namespace TaylorGPS.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
