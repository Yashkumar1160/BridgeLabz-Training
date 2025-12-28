using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_extras.csharp_built_in_functions
{
    internal class CalculateGcdAndLcm
    {
        public static void Main(string[] args)
        {
            //take first number input
            Console.WriteLine("Enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            //take second number input
            Console.WriteLine("Enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            //call FindGCD method and display result
            int gcd = FindGCD(firstNumber, secondNumber);
            Console.WriteLine("GCD is : " + gcd);
            //call FindLCM method and display result
            int lcm = FindLCM(firstNumber, secondNumber);
            Console.WriteLine("LCM is : " + lcm);

        }
        //Method to find gcd
        public static int FindGCD(int firstNumber, int secondNumber)
        {   //loop until remainder becomes 0
            while (secondNumber != 0)
            {
                int temp = secondNumber;
                secondNumber = firstNumber % secondNumber;
                firstNumber = temp;

            }
            return firstNumber;
        }
        //Method to find lcm
        public static int FindLCM(int firstNumber, int secondNumber)
        {
            //calculate and return lcm
            return (firstNumber/ FindGCD(firstNumber, secondNumber))*secondNumber;
        }
    }
}
