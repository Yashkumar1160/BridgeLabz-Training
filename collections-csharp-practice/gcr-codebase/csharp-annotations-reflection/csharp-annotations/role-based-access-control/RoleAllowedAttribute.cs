using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.role_based_access_control
{
    //custom attribute to restrict access based on role
    [AttributeUsage(AttributeTargets.Method)]
    internal class RoleAllowedAttribute : Attribute
    {
        //property to store allowed role
        public string Role { get; }

        //constructor 
        public RoleAllowedAttribute(string role)
        {
            Role = role;
        }
    }
}
