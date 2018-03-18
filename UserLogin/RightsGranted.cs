using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class RightsGranted
    {
        public static Dictionary<UserRoles, List<RoleRights>> rights = new Dictionary<UserRoles, List<RoleRights>>();

        public static void InitRoleRights()
        {
            List<RoleRights> rolesAdmin = new List<RoleRights>();
            rolesAdmin.Add(RoleRights.CanEditUsers);
            rolesAdmin.Add(RoleRights.CanSeeLogs);
            rolesAdmin.Add(RoleRights.CanEditStudents);
            rights.Add(UserRoles.ADMIN, rolesAdmin);

            List<RoleRights> rolesProf = new List<RoleRights>();
            rolesProf.Add(RoleRights.CanEditStudents);
            rights.Add(UserRoles.PROFESSOR, rolesProf);
        }

        public static bool HasRights(UserRoles role, RoleRights right)
        {
            return rights[role].Contains(right);
        }
    }
}
