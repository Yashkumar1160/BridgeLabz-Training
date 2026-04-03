using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_algorithms_analysis
{
    internal class Fibonacci
    {
        public static void Main(string[] args)
        {
            //take number input
            Console.Write("ENTER A NUMBER: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //call recursive method
            DateTime recStart = DateTime.Now;

            int fibonacci = FindFibonacciRecursive(number);

            DateTime recEnd = DateTime.Now;

            Console.WriteLine("USING RECURSION: " + fibonacci);
            Console.WriteLine("RECURSIVE TIME: " + (recEnd - recStart).TotalMilliseconds + " ms");

            //call iterative method
            DateTime itrStart = DateTime.Now;

            FindFibonacci(number);

            DateTime itrEnd = DateTime.Now;
            Console.WriteLine("ITERATIVE TIME: " + (itrEnd - itrStart).TotalMilliseconds + " ms");
        }

        //method to find fibonacci of number using recursion
        public static int FindFibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;

            return FindFibonacciRecursive(n - 1) + FindFibonacciRecursive(n - 2);
        }

        //method to find fibonacci number iteratively
        public static void FindFibonacci(int number)
        {
            int a = 0;
            int b = 1;
            int sum = 0;

            for (int i = 2; i <= number; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }

            Console.WriteLine("USING ITERATIVE METHOD: " + b);
        }
    }
}
