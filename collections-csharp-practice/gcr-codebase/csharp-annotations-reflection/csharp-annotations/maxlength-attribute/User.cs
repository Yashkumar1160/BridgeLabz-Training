using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.maxlength_attribute
{
    internal class User
    {
        //username field with max length limit
        [MaxLength(10)]
        private string username;

        //constructor
        public User(string username)
        {
            //get field info using reflection
            FieldInfo field =
                this.GetType().GetField("username",
                BindingFlags.NonPublic | BindingFlags.Instance);

            //get MaxLength attribute
            MaxLengthAttribute attr =
                (MaxLengthAttribute)Attribute.GetCustomAttribute(
                    field, typeof(MaxLengthAttribute));

            //check length
            if (username.Length > attr.Value)
            {
                //throw exception if length exceeds limit
                throw new ArgumentException("Username exceeds max length");
            }

            //assign value
            this.username = username;
        }

        //method to display username
        public void Display()
        {
            Console.WriteLine("Username: " + username);
        }
    }
}
