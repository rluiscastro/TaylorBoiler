using System.Collections.Generic;
using TaylorGPS.Roles.Dto;
using TaylorGPS.Users.Dto;

namespace TaylorGPS.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}