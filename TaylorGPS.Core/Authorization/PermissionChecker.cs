using Abp.Authorization;
using TaylorGPS.Authorization.Roles;
using TaylorGPS.Authorization.Users;

namespace TaylorGPS.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
