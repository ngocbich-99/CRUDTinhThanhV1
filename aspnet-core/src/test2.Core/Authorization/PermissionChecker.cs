using Abp.Authorization;
using test2.Authorization.Roles;
using test2.Authorization.Users;

namespace test2.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
