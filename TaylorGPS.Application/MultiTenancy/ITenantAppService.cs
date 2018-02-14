using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TaylorGPS.MultiTenancy.Dto;

namespace TaylorGPS.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
