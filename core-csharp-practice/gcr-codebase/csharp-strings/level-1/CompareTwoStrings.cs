using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.level_1
{
    internal class CompareTwoStrings
    {
        public static void Main(string[] args)
        {
            //take user input string
            Console.WriteLine("Enter First String");
            string firstString = Console.ReadLine();
            Console.WriteLine("Enter Second String");
            string secondString = Console.ReadLine();

            //call the CompareStrings() method
            bool answer = CompareStrings(firstString, secondString);
            Console.WriteLine("Using CompareStrings() method : " + answer);
            //using Equals() method
            bool isEqual = firstString.Equals(secondString);
            Console.WriteLine("Using Equals() method : " + isEqual);


            //Compare both the methods
            if (isEqual && answer)
            {   //if both are equal
                Console.WriteLine("Both are equal");
            }
            else
            {   //if both are different
                Console.WriteLine("Both are different");
            }



        }
        //Method to compare two strings
        public static bool CompareStrings(string firstString, string secondString)
        {
            //compare both strings
            for (int i = 0; i < firstString.Length; i++)
            {
                if (firstString[i] != secondString[i])
                {   //if both strings are different
                    return false;
                }
            }
            //if both are same then return
            return true;
        }
    }
}
