using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.level_1
{
    internal class FormatExample
    {
        public static void Main(string[] args)
        {
            //call method to generate and handle exception
            ExampleOfFormatException();

        }
        //Method to generate and handle FormatException
        public static void ExampleOfFormatException()
        {
            //try block
            try
            {
                //generate exception
                int number = Convert.ToInt32("hello");

            }
            //catch block
            catch (FormatException)
            {
                //catch and display exception
                Console.WriteLine("FormatException caught");
            }
        }
    }
}
