using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.role_based_access_control
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //current user role
            string currentUserRole = "USER";

            //create service object
            AdminService service = new AdminService();

            //get method info
            MethodInfo method = typeof(AdminService).GetMethod("DeleteUser");

            //get RoleAllowed attribute
            RoleAllowedAttribute attr = (RoleAllowedAttribute)Attribute.GetCustomAttribute(method, typeof(RoleAllowedAttribute));

            //check access
            if (attr != null && attr.Role == currentUserRole)
            {
                //access allowed
                method.Invoke(service, null);
            }
            else
            {
                //access denied
                Console.WriteLine("Access Denied!");
            }
        }
    }
}
