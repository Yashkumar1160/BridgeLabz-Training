using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.csharp_string_extras
{
    internal class AnagramStrings
    {
        public static void Main(string[] args)
        {
            //take first string input
            Console.WriteLine("Enter first string");
            string firstString = Console.ReadLine();

            //take second string input
            Console.WriteLine("Enter second string");
            string secondString = Console.ReadLine();

            //call CheckAnagram method
            bool result = CheckAnagram(firstString, secondString);

            //display result
            Console.WriteLine(result ? "Anagram string" : "Not Anagram");
        }
        //Method to check anagram
        public static bool CheckAnagram(string firstString, string secondString)
        {   //check the length of both strings
            if (firstString.Length != secondString.Length)
            {
                return false;
            }
            //array to store count of characters
            int[] frequency = new int[256];
            //increase frequency for first string
            foreach (char ch in firstString)
            {
                frequency[ch]++;
            }
            //decrease frequency for second string
            foreach (char ch in secondString)
            {
                frequency[ch]--;
            }
            //check array 
            foreach (int count in frequency)
            {
                if (count != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
