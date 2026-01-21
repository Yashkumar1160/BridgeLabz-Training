using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class WordFrequencyCounter
    {
        public static void Main(string[] args)
        {
            //take input sentence
            Console.WriteLine("Enter Text:");
            string text = Console.ReadLine();

            //call CountWords method
            CountWords(text);
        }


        //method to count word frequency
        public static void CountWords(string text)
        {
            //dictionary to store word count
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            //convert to lowercase and split words
            string[] words = text.ToLower().Split(' ', ',', '!', '.');

            //loop through words
            foreach (string word in words)
            {

                if (word == "")
                    continue;

                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount.Add(word, 1);
                }
            }

            Console.WriteLine("Word Frequency:");
            foreach (var item in wordCount)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }
    }
}
