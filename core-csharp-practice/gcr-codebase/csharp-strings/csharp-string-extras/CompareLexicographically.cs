using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.csharp_string_extras
{
    internal class CompareLexicographically
    {
        public static void Main(string[] args)
        {
            //take first string input
            Console.WriteLine("Enter first string");
            string firstString = Console.ReadLine();

            //take second string input
            Console.WriteLine("Enter second string");
            string secondString = Console.ReadLine();

            //call CompareStrings method
            CompareStrings(firstString, secondString);
        }
        //Method to compare two strings lexicographically
        public static void CompareStrings(string firstString, string secondString)
        {
            int minLength = Math.Min(firstString.Length, secondString.Length);

            //compare characters
            for (int i = 0; i < minLength; i++)
            {
                if (firstString[i] < secondString[i])
                {
                    Console.WriteLine(firstString + " comes before " + secondString + " in lexicographical order");
                    return;
                }
                else if (firstString[i] > secondString[i])
                {
                    Console.WriteLine(secondString + " comes before " + firstString);
                    return;
                }
            }
            //if all characters are same then compare length
            if (firstString.Length < secondString.Length)
            {
                Console.WriteLine(firstString + " comes befors " + secondString + " lexicographical order");

            }
            else if (firstString.Length > secondString.Length)
            {
                Console.WriteLine(secondString + " comes befors " + firstString + " in lexicographical order");

            }
            else
            {
                Console.WriteLine("Both strings are same");
            }
        }
    }
}
