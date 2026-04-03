using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_exceptions
{
    internal class PropagatingExceptions
    {
        public static void Main(string[] args)
        {
            //try block in Main to catch propagated exception
            try
            {
                //call Method2 which calls Method1
                Method2();
            }
            //catch ArithmeticException propagated from Method1
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Handled exception in Main: " + ex.Message);
            }
            //catch FormatException for invalid input
            catch (FormatException)
            {
                Console.WriteLine("FormatException occurred: Please enter valid numeric values");
            }
        }

        //Method1 performs division and may throw exception
        public static void Method1()
        {
            //take first number from user
            Console.Write("ENTER NUMBER 1: ");
            int num1 = int.Parse(Console.ReadLine());

            //take second number from user
            Console.Write("ENTER NUMBER 2: ");
            int num2 = int.Parse(Console.ReadLine());

            //perform division
            int result = num1 / num2;

            //print result if no exception
            Console.WriteLine("Result: " + result);
        }

        //Method2 calls Method1 without handling exception
        public static void Method2()
        {
            Method1();
        }
    }
}
