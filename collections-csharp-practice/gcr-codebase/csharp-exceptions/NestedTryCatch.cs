using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_exceptions
{
    internal class NestedTryCatch
    {
        public static void Main(string[] args)
        {
            //numbers array
            int[] numbers = { 10, 20, 30, 40, 50 };

            //try block for array index access
            try
            {
                //take user input for index
                Console.Write("ENTER INDEX: ");
                int index = int.Parse(Console.ReadLine());

                //nested try block for division
                try
                {
                    //take user input
                    Console.Write("ENTER DIVISOR: ");
                    int divisor = int.Parse(Console.ReadLine());

                    //perform division
                    int result = numbers[index] / divisor;

                    //print result if no exception
                    Console.WriteLine("Result: " + result);
                }
                //catch DivideByZeroException
                catch (DivideByZeroException)
                {
                    Console.WriteLine("DivideByZeroException occurred: Cannot divide by zero!");
                }
                //catch FormatException
                catch (FormatException)
                {
                    Console.WriteLine("FormatException occurred: Please enter a valid numeric divisor");
                }
            }
            //catch IndexOutOfRangeException
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException occurred: Invalid array index!");
            }
            //catch FormatException
            catch (FormatException)
            {
                Console.WriteLine("FormatException occurred: Please enter a valid numeric index");
            }
        }
    }
}
