using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.retrieve_attributes
{
    internal class Program
    {
        public static void Main()
        {
            //get type information
            Type type = typeof(Book);

            //get custom attribute
            AuthorAttribute attribute = (AuthorAttribute)type.GetCustomAttribute(typeof(AuthorAttribute));

            //print author name
            Console.WriteLine("Author Name: " + attribute.Name);
        }
    }
}
