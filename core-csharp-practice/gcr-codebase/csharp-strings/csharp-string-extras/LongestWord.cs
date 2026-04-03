using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.csharp_string_extras
{
    internal class LongestWord
    {
        public static void Main(string[] args)
        {
            //take input sentence
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();
            //call method to find longest word
            string longest = FindLongestWord(sentence);
            //display result
            Console.WriteLine("Longest word in the sentence is : " + longest);
        }
        //Method to find longest word
        public static string FindLongestWord(string sentence)
        {
            //split the sentence with space
            string[] words = sentence.Split(' ');
            //assume that first word is the longest
            string longest = words[0];
            //loop through array words
            for (int i = 0; i < words.Length; i++)
            {   //compare current word with longest word
                if (words[i].Length > longest.Length)
                {
                    longest = words[i];
                }
            }
            //return longest word
            return longest;

        }
    }
}
