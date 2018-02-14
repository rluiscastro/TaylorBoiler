using Abp.AutoMapper;
using TaylorGPS.Sessions.Dto;

namespace TaylorGPS.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}