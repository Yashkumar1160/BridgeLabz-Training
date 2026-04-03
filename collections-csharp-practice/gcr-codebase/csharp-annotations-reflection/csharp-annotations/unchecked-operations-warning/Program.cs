using System;
using System.Collections;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.unchecked_operations_warning
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //disable warning for non-generic collections
            #pragma warning disable 618

            //create ArrayList without generics
            ArrayList list = new ArrayList();

            //add different data types
            list.Add(10);
            list.Add("Hello");

            //enable warnings again
            #pragma warning restore 618

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
