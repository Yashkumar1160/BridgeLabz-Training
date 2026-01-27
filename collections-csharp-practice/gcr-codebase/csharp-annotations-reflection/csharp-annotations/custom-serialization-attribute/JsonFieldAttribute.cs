using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.custom_serialization_attribute
{
    //custom attribute to mark fields for JSON serialization
    [AttributeUsage(AttributeTargets.Field)]
    public class JsonFieldAttribute : Attribute
    {
        //property to store custom JSON key name
        public string Name { get; set; }
    }
}
