using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using TaylorGPS.Authorization.Users;
using TaylorGPS.MultiTenancy;
using TaylorGPS.Users;
using Microsoft.AspNet.Identity;

namespace TaylorGPS
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class TaylorGPSAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected TaylorGPSAppServiceBase()
        {
            LocalizationSourceName = TaylorGPSConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}