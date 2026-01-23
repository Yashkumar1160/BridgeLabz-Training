using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_exceptions
{
    //custom exception class
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }

    internal class CheckAge
    {
        //method to validate age
        public static void ValidateAge(int age)
        {
            if (age < 18)
            {
                //throw custom exception if age is less than 18
                throw new InvalidAgeException("Age must be 18 or above");
            }
        }

        public static void Main(string[] args)
        {
            //try block
            try
            {
                //take user input for age
                Console.Write("ENTER YOUR AGE: ");
                int age = int.Parse(Console.ReadLine());

                //call method to validate age
                ValidateAge(age);

                //if no exception occurred
                Console.WriteLine("Access granted!");
            }
            //catch custom InvalidAgeException
            catch (InvalidAgeException ex)
            {
                Console.WriteLine("InvalidAgeException occurred: " + ex.Message);
            }
            //catch FormatException
            catch (FormatException)
            {
                Console.WriteLine("FormatException occurred: Please enter a valid numeric value");
            }
        }
    }
}
