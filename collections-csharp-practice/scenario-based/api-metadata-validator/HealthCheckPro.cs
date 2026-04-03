using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.api_metadata_validator
{
    internal class HealthCheckPro
    {
        //method to scan controller class
        public static void ScanAPIs(Type controllerType)
        {
            //get all methods of the class
            MethodInfo[] methods = controllerType.GetMethods(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            Console.WriteLine("\n--- API Documentation ---");

            //loop through each method
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("\nMethod Name: " + method.Name);

                //check if method has PublicAPI attribute
                bool isPublic = method.IsDefined(typeof(PublicApiAttribute), false);

                //check if method has RequiresAuth attribute
                bool needsAuth = method.IsDefined(typeof(RequiresAuthAttribute), false);

                //if method is public
                if (isPublic)
                {
                    Console.WriteLine("Type: Public API");
                }
                else
                {
                    Console.WriteLine("WARNING: Missing [PublicAPI] attribute");
                }

                //check authentication requirement
                if (needsAuth)
                {
                    Console.WriteLine("Authentication: Required");
                }
                else
                {
                    Console.WriteLine("Authentication: Not Required");
                }
            }
        }
    }
}