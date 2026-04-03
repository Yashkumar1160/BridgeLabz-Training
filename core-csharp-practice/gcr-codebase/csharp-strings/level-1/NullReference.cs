using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.level_1
{
    internal class NullReference
    {
        public static void Main(string[] args)
        {
            //call the method
            ExampleOfNullReference();
        }
        //Method to demonstrate NullReferenceException
        public static void ExampleOfNullReference()
        {
            //try block
            try
            {   //initialize string with null
                string text = null;
                Console.WriteLine(text.Length);
            }
            //catch block
            catch (NullReferenceException)
            {   //catch exception and display message
                Console.WriteLine("NullReferenceException caught");
            }
        }
    }
}
