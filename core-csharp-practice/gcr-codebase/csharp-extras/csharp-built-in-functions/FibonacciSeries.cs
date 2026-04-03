using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_extras.csharp_built_in_functions
{
    internal class FibonacciSeries
    {
        public static void Main(string[] args)
        {
            //take input for number of terms
            Console.WriteLine("Enter number of terms");
            int numberOfTerms = Convert.ToInt32(Console.ReadLine());

            //call GenerateFibonacciSequence() method
            GenerateFibonacciSequence(numberOfTerms);
        }
        //Method to generate fibonacci sequence
        public static void GenerateFibonacciSequence(int numberOfTerms)
        {
            //first fibonacci number
            int a = 0;
            //second fibonacci number
            int b = 1;
            //loop to generate fibonacci sequence
            for (int i = 1; i <= numberOfTerms; i++)
            {
                Console.Write(a + " ");
                //calculate next fibonacci number
                int next = a + b;
                //update previous variables
                a = b;
                b = next;
            }
        }
    }
}
