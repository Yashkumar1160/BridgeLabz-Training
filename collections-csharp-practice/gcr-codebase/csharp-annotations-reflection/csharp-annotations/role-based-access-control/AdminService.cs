using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.role_based_access_control
{
    internal class AdminService
    {
        //only ADMIN role can access this method
        [RoleAllowed("ADMIN")]
        public void DeleteUser()
        {
            Console.WriteLine("User deleted successfully.");
        }
    }
}
