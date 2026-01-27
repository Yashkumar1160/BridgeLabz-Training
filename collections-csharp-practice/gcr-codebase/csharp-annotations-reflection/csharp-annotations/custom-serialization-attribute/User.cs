using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.custom_serialization_attribute
{
    internal class User
    {
        //map Username field to user_name in JSON
        [JsonField(Name = "user_name")]
        public string Username;

        //map Email field to email_id in JSON
        [JsonField(Name = "email_id")]
        public string Email;

        //this field will not be serialized
        public int Age;
    }
}
