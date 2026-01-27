using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.maxlength_attribute
{
    //custom attribute to define max length
    [AttributeUsage(AttributeTargets.Field)]
    public class MaxLengthAttribute : Attribute
    {
        //property to store max length
        public int Value { get; }

        //constructor
        public MaxLengthAttribute(int value)
        {
            Value = value;
        }
    }
}
