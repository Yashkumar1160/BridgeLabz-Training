using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_linear_binary_search
{
    internal class SearchWord
    {
        public static void Main(string[] args)
        {
            //take size of array
            Console.Write("ENTER SIZE OF ARRAY: ");
            int size = Convert.ToInt32(Console.ReadLine());

            //create array to store sentences
            string[] sentences = new string[size];

            //take input sentences
            for (int i = 0; i < sentences.Length; i++)
            {
                Console.Write("ENTER A SENTENCE: ");
                sentences[i] = Console.ReadLine();
            }

            //call SearchSpecificWord method
            SearchSpecificWord(sentences);
        }

        //method to search for a specific word in sentences
        public static void SearchSpecificWord(string[] sentences)
        {
            //take word to search
            Console.Write("ENTER WORD TO SEARCH: ");
            string word = Console.ReadLine();

            //loop through sentences 
            for (int i = 0; i < sentences.Length; i++)
            {
                //check if sentence contains the word
                if (sentences[i].ToLower().Contains(word.ToLower()))
                {
                    Console.WriteLine($"WORD: {word} IS PRESENT IN -> {sentences[i]}");
                    return;
                }
            }
            Console.WriteLine("NO SENTENCE FOUND");
        }
    }
}
