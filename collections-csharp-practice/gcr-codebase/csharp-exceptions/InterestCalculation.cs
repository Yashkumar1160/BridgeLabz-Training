using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_exceptions
{
    internal class InterestCalculation
    {
        public static void Main(string[] args)
        {
            //try block
            try
            {
                //take input for amount
                Console.Write("Enter principal amount: ");
                double amount = double.Parse(Console.ReadLine());

                //take input for rate
                Console.Write("Enter rate of interest: ");
                double rate = double.Parse(Console.ReadLine());

                //take input for years
                Console.Write("Enter number of years: ");
                int years = int.Parse(Console.ReadLine());

                //call method to calculate interest
                double interest = CalculateInterest(amount, rate, years);
                Console.WriteLine("Calculated Interest: " + interest);
            }
            //catch ArgumentException from method
            catch (ArgumentException ex)
            {
                Console.WriteLine("ArgumentException occurred: Invalid input: " + ex.Message);
            }
            //catch FormatException 
            catch (FormatException)
            {
                Console.WriteLine("FormatException occurred: Please enter valid numeric values");
            }
        }

        //method to calculate simple interest
        public static double CalculateInterest(double amount, double rate, int years)
        {
            //check for negative amount or rate
            if (amount < 0 || rate < 0)
            {
                //throw ArgumentException for invalid input
                throw new ArgumentException("Amount and rate must be positive");
            }

            //calculate simple interest
            return (amount * rate * years) / 100;
        }
    }
}
