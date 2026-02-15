using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techville.exceptions;

namespace techville.utilities
{
    public class InputValidator
    {
        //method to get valid string input 
        public static string GetValidString(string message)
        {
            //infinite loop until user enters valid input
            while (true)
            {
                try
                {
                    Console.Write(message);
                    string input = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(input))
                        throw new InvalidInputException("Input cannot be empty.");

                    return input;
                }
                catch (InvalidInputException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception Caught: "+ex.Message);
                }
            }
        }


        //method to get valid integer input 
        public static int GetValidPositiveInt(string message)
        {
            //infinite loop until user enters valid input
            while (true)
            {
                try
                {
                    Console.Write(message);
                    int value = int.Parse(Console.ReadLine());

                    if (value <= 0)
                        throw new InvalidNumberException("Enter positive integer only.");

                    return value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format. Enter numbers only.");
                }
                catch (InvalidNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        //method to get valid double input 
        public static double GetValidPositiveDouble(string message)
        {
            //infinite loop until user enters valid input
            while (true)
            {
                try
                {
                    Console.Write(message);
                    double value = double.Parse(Console.ReadLine());

                    if (value <= 0)
                        throw new InvalidNumberException("Enter positive number only.");

                    return value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format.");
                }
                catch (InvalidNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        //method to get valid non negative input 
        public static int GetValidNonNegativeInt(string message)
        {
            //infinite loop until user enters valid input
            while (true)
            {
                try
                {
                    Console.Write(message);
                    int value = int.Parse(Console.ReadLine());

                    if (value < 0)
                        throw new InvalidNumberException("Enter 0 or positive integer.");

                    return value;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format! Enter numbers only.");
                }
                catch (InvalidNumberException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        //M-4 Method to Format name 
        public static string FormatName(string name)
        {
            name = name.Trim().ToLower();
            return char.ToUpper(name[0]) + name.Substring(1);
        }

        //M-4 Method to Validate email format
        public static string GetValidEmail(string message)
        {
            //infinite loop until user enters valid input
            while (true)
            {
                try
                {
                    Console.Write(message);
                    string email = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(email))
                        throw new InvalidInputException("Email cannot be empty.");

                    if (!email.Contains("@") || !email.Contains("."))
                        throw new InvalidEmailFormatException("Invalid email format.");

                    return email;
                }
                catch (InvalidInputException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidEmailFormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        //M-4 Method to Format address 
        public static string FormatAddress(string address)
        {
            return address.Trim();
        }

    }
}