using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_extras.csharp_built_in_functions
{
    internal class Factorial
    {
        public static void Main(string[] args)
        {
            //take input number
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            //call FindFactorial method and display result
            int factorial = FindFactorial(number);
            Console.WriteLine("The factorial of number is : " + factorial);
        }
        //Recursive Method to find factorial
        public static int FindFactorial(int number)
        {
            //base condition 
            if (number == 0)
            {
                return 1;
            }
            //recursive call
            return number * FindFactorial(number - 1);
        }
    }
}
