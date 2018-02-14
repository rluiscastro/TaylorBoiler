using System.Threading.Tasks;
using Abp.Application.Services;
using TaylorGPS.Sessions.Dto;

namespace TaylorGPS.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
