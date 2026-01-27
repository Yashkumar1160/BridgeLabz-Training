using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.dependency_injection.InjectionAttribute;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.dependency_injection
{
    internal class DIContainer
    {
        public static void InjectDependencies(object obj)
        {
            //get type info
            Type type = obj.GetType();

            //get all fields
            FieldInfo[] fields = type.GetFields();

            //loop through fields
            foreach (FieldInfo field in fields)
            {
                //check if Inject attribute exists
                if (field.GetCustomAttribute(typeof(InjectAttribute)) != null)
                {
                    //create dependency object
                    object dependency = Activator.CreateInstance(field.FieldType);

                    //set dependency
                    field.SetValue(obj, dependency);
                }
            }
        }
    }
}
