using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.csharp_string_extras
{
    internal class MostFrequentCharacter
    {
        public static void Main(string[] args)
        {
            //take string input
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();

            //call the FindMostFrequentCharacter method
            Console.WriteLine("most frequent character is : " + FindMostFrequentCharacter(text));
        }
        //Method to find most frequent character
        public static char FindMostFrequentCharacter(string text)
        {
            int maxCount = 0;
            char mostFrequent = text[0];

            //loop through each character 
            for (int i = 0; i < text.Length; i++)
            {
                int count = 0;
                //count occurrences of current character
                for (int j = 0; j < text.Length; j++)
                {
                    if (text[i] == text[j])
                    {
                        count++;
                    }
                }
                //update max if needed
                if (count > maxCount)
                {
                    maxCount = count;
                    mostFrequent = text[i];
                }
            }
            return mostFrequent;
        }
    }
}
