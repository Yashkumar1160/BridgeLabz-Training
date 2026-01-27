using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.json_representation
{
    internal class JsonConverter
    {
        //method to convert object to json-like string
        public static string ToJson(object obj)
        {
            //get type info
            Type type = obj.GetType();

            //string builder for json text
            StringBuilder json = new StringBuilder();

            json.Append("{");

            //get all fields
            FieldInfo[] fields = type.GetFields();

            //loop through fields
            for (int i = 0; i < fields.Length; i++)
            {
                //get field name
                string name = fields[i].Name;

                //get field value
                object value = fields[i].GetValue(obj);

                //add to json
                json.Append($"\"{name}\":\"{value}\"");

                //add comma except last
                if (i < fields.Length - 1)
                    json.Append(", ");
            }

            json.Append("}");

            return json.ToString();
        }
    }
}
