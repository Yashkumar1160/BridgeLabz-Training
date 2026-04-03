using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.csharp_string_extras
{
    internal class CountVowelsAndConsonants
    {
        public static void Main(string[] args)
        {
            //take string input
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();
            //call the method to print vowels and consonants count
            CountVowelsConsonants(text);
        }
        //Method to count vowels and consonants
        public static void CountVowelsConsonants(string text)
        {
            //initialize vowelsCount and consonantsCount variable to 0
            int vowelsCount = 0;
            int consonantsCount = 0;
            //loop to check for vowels and consonants
            foreach (char ch in text.ToLower())
            {
                if (ch >= 'a' && ch <= 'z')
                {   //increase count if vowel found
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    {
                        vowelsCount++;
                    }
                    else
                    {//increase count if consonant found
                        consonantsCount++;
                    }
                }
            }
            Console.WriteLine("Vowels: " + vowelsCount);
            Console.WriteLine("Consonants: " + consonantsCount);

        }
    }
}
