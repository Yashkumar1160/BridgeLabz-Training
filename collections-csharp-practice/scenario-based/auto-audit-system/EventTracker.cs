using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.auto_audit_system
{
    internal class EventTracker
    {
        //method to scan classes and print audit logs
        public static void ScanAndLogEvents(Type targetType)
        {
            //get all public instance methods of the class
            MethodInfo[] methods = targetType.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            Console.WriteLine("\n--- Audit Trail Logs ---");

            //loop through each method
            foreach (MethodInfo method in methods)
            {
                //check if method has AuditTrail attribute
                AuditTrailAttribute auditAttr =method.GetCustomAttribute<AuditTrailAttribute>();

                //only log audited methods
                if (auditAttr != null)
                {
                    Console.WriteLine("Event  : " + auditAttr.ActionName);
                    Console.WriteLine("Method : " + method.Name);
                    Console.WriteLine("Class  : " + targetType.Name);
                    Console.WriteLine("Time   : " + DateTime.Now.ToString("dd-MM-yyyy hh:mm tt"));
                    Console.WriteLine("User   : SystemUser");
                    Console.WriteLine("-----------------------------");
                }
            }
        }
    }
}
