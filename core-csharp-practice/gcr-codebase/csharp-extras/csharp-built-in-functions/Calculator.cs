using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_extras.csharp_built_in_functions
{
    internal class Calculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(("Enter second number"));
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose operation: (+ - * /)");
            char operation = Console.ReadLine()[0];

            double answer = Calculate(firstNumber, secondNumber, operation);
            Console.WriteLine("Answer is : " + answer);
        }
        //Method to calculate answer
        public static double Calculate(double firstNumber, double secondNumber, char operation)
        {
            switch (operation)
            {
                case '+':
                    //addition
                    return firstNumber + secondNumber;
                case '-':
                    //subtraction
                    return firstNumber - secondNumber;
                case '*':
                    //multiplication
                    return firstNumber * secondNumber;
                case '/':
                    //division
                    return firstNumber / secondNumber;
                default:
                    //default case
                    return 0;
            }
        }
    }
}
