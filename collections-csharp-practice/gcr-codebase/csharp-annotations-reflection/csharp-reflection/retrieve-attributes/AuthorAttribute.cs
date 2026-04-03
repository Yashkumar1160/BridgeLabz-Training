using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.retrieve_attributes
{
    //custom attribute to store author name
    [AttributeUsage(AttributeTargets.Class)]
    internal class AuthorAttribute : Attribute
    {
        //property to store author name
        public string Name { get; }

        //constructor 
        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }
}
