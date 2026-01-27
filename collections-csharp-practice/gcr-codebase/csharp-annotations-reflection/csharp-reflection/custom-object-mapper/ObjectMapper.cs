using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.custom_object_mapper
{
    internal class ObjectMapper
    {
        //method to map dictionary values to object
        public static T ToObject<T>(Dictionary<string, object> properties)
            where T : new()
        {
            //create object dynamically
            T obj = new T();

            //get type information
            Type type = typeof(T);

            //loop through dictionary
            foreach (var item in properties)
            {
                //get field name from dictionary key
                FieldInfo field = type.GetField(item.Key);

                //if field exists
                if (field != null)
                {
                    //set field value
                    field.SetValue(obj, item.Value);
                }
            }

            return obj;
        }
    }
}
