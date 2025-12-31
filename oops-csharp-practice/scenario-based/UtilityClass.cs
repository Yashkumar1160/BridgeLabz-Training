using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based
{
    internal class UtilityClass
    {
        public static void Main(string[] args)
        {
            DisplayChoices();
        }

        //---------------DISPLAY CHOICES---------------
        //method to display choices
        public static void DisplayChoices()
        {
            //take first number input
            Console.WriteLine("ENTER FIRST NUMBER");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            //take second number input
            Console.WriteLine("ENTER SECOND NUMBER");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            //take a negative number input
            Console.WriteLine("ENTER A NEGATIVE NUMBER:");
            int negativeNumber = Convert.ToInt32(Console.ReadLine());

            int numberZero = 0;

            //infinite loop to display choices
            while (true)
            {
                Console.WriteLine("\n1. Find Factorial");
                Console.WriteLine("\n2. Check Prime");
                Console.WriteLine("\n3. Find GCD");
                Console.WriteLine("\n4. Find Fibonacci");
                Console.WriteLine("\n5. Exit");

                //take user choice
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    //if user enters 1
                    case 1:
                        Console.WriteLine("FACTORIAL TEST RESULTS:");
                        Console.WriteLine($"Factorial with positive number {firstNumber}: {FindFactorial(firstNumber)}");
                        Console.WriteLine($"Factorial test with negative number {negativeNumber}: {FindFactorial(negativeNumber)}");
                        Console.WriteLine($"Factorial test with number {numberZero}: {FindFactorial(numberZero)}");
                        break;

                    //if user enters 2
                    case 2:
                        Console.WriteLine("PRIME TEST RESULTS:");
                        Console.WriteLine($"Check Prime test with positive number {firstNumber}: {CheckPrime(firstNumber)}");
                        Console.WriteLine($"Check Prime test with negative number {negativeNumber}: {CheckPrime(negativeNumber)}");
                        Console.WriteLine($"Check Prime test with number {numberZero}: {CheckPrime(numberZero)}");
                        break;

                    //if user enters 3
                    case 3:
                        Console.WriteLine("GCD TEST RESULTS:");
                        Console.WriteLine($"GCD test with positive numbers {firstNumber} , {secondNumber}: {FindGCD(firstNumber, secondNumber)}");
                        Console.WriteLine($"GCD Prime test with negative number {negativeNumber} , {secondNumber}: {FindGCD(negativeNumber, secondNumber)}");
                        Console.WriteLine($"GCD Prime test with number {numberZero} , {secondNumber}: {FindGCD(numberZero, secondNumber)}");
                        break;

                    //if user enters 4
                    case 4:
                        Console.WriteLine("FIBONACCI TEST RESULTS:");
                        Console.WriteLine($"Fibonacci with positive number {firstNumber}: {FindFibonacci(firstNumber)}");
                        Console.WriteLine($"Fibonacci test with negative number {negativeNumber}: {FindFibonacci(negativeNumber)}");
                        Console.WriteLine($"Fibonacci test with number {numberZero}: {FindFibonacci(numberZero)}");

                        break;

                    //if user enters 5
                    case 5:
                        Console.WriteLine("EXIT SUCCESSFUL");
                        return;

                    ////if user enters invalid input
                    default:
                        Console.WriteLine("INVALID CHOICE");
                        break;
                }

            }
        }

        //--------------FIND FACTORIAL-------------------
        //method to find factorial of a number
        public static long FindFactorial(int number)
        {
            //return -1 if number is negative
            if (number < 0)
            {
                return -1;
            }

            //initialize factorial variable with 1
            long factorial = 1;

            //loop to find factorial
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        //----------------CHECK PRIME--------------------
        //method to check if a number is prime
        public static bool CheckPrime(int number)
        {
            //prime numbers are larger than 1
            if (number <= 1)
            {
                return false;
            }

            //loop to check if number is divisible 
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }

            }

            return true;

        }

        //---------------FIND GCD---------------------
        //method to find GCD of two numbers
        public static int FindGCD(int firstNumber, int secondNumber)
        {
            //convert negative numbers to positive
            firstNumber = Math.Abs(firstNumber);

            secondNumber = Math.Abs(secondNumber);

            //if both numbers are equal then GCD is the number itself
            if (firstNumber == secondNumber)
            {
                return secondNumber;
            }

            //if one number is zero then return another
            if (secondNumber == 0)
            {
                return firstNumber;
            }

            //loop until second number is 0
            while (secondNumber != 0)
            {
                int temp = secondNumber;
                secondNumber = firstNumber % secondNumber;
                firstNumber = temp;
            }

            return firstNumber;
        }

        //------------------FIND FIBONACCI----------------
        //method to find fibonacci series
        public static int FindFibonacci(int number)
        {
            //return -1 if number is negative
            if (number < 0)
            {
                return -1;
            }

            //return 0 if number is 0
            if (number == 0)
            {
                return 0;
            }

            //return 1 if number is 1
            if (number == 1)
            {
                return 1;
            }

            //initialize three variables a, b and c
            int a = 0;
            int b = 1;
            int c = 0;


            //loop to find fibonacci numbers
            for (int i = 2; i <= number; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }
    }
}


