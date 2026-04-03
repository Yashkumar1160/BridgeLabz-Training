using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.level_1
{
    internal class ArgumentOutOfRange
    {
        public static void Main(string[] args)
        {
            //call the method to generate and handle exception
            ExampleOfArgumentOutOfRange();
        }
        //Method to generate and handle ArgumentOutOfRangeException
        public static void ExampleOfArgumentOutOfRange()
        {
            //try block
            try
            {
                string text = "hello";
                //generate exception
                Console.WriteLine(text.Substring(4, 10));
            }
            //catch block
            catch (ArgumentOutOfRangeException)
            {
                //catch and display exception
                Console.WriteLine("ArgumentOutOfRangeException caught");
            }
        }
    }
}
