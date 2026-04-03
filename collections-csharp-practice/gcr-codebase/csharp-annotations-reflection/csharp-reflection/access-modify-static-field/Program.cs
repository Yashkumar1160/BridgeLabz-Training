using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.access_modify_static_field
{
    internal class Program
    {
        public static void Main()
        {
            //get type information
            Type type = typeof(Configuration);

            //get private static field
            FieldInfo field = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

            //set new value to static field
            field.SetValue(null, "NEW_SECRET_KEY");

            //print updated value
            Configuration.PrintKey();
        }
    }
}
