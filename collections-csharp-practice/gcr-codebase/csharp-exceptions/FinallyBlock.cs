using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_exceptions
{
    internal class FinallyBlock
    {
        public static void Main(string[] args)
        {
            //try block
            try
            {
                //take first number
                Console.Write("Enter first number: ");
                int num1 = int.Parse(Console.ReadLine());

                //take second number
                Console.Write("Enter second number: ");
                int num2 = int.Parse(Console.ReadLine());

                //division operation
                int result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            //catch DivideByZeroException
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException occurred: Cannot divide by zero");
            }
            //catch FormatException
            catch (FormatException)
            {
                Console.WriteLine("FormatException occurred: Please enter valid numeric values");
            }
            //finally block 
            finally
            {
                Console.WriteLine("Operation completed");
            }
        }
    }
}
