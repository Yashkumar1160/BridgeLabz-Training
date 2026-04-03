using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.custom_serialization_attribute
{
    internal class JsonSerializer
    {
        //method to convert object to JSON string
        public static string ConvertToJson(object obj)
        {
            //string builder to build JSON
            StringBuilder json = new StringBuilder();
            json.Append("{");

            //get all fields of the object
            FieldInfo[] fields = obj.GetType().GetFields();

            bool firstField = true;

            foreach (FieldInfo field in fields)
            {
                //check if JsonField attribute is applied
                JsonFieldAttribute attribute =
                    field.GetCustomAttribute<JsonFieldAttribute>();

                if (attribute != null)
                {
                    //add comma for multiple fields
                    if (!firstField)
                        json.Append(", ");

                    //add key and value
                    json.Append("\"" + attribute.Name + "\": ");
                    json.Append("\"" + field.GetValue(obj) + "\"");

                    firstField = false;
                }
            }

            json.Append("}");
            return json.ToString();
        }
    }
}
