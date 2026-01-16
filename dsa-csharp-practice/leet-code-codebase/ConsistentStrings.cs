using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.leet_code_codebase
{
    internal class ConsistentStrings
    {
        public static void Main(string[] args)
        {
            //take allowed string
            Console.Write("ENTER ALLOWED STRINGS: ");
            string allowed=Console.ReadLine();

            //take number of words
            Console.Write("ENTER NUMBER OF WORDS: ");
            int numberOfWords=Convert.ToInt32(Console.ReadLine());

            //create string array to store words
            string[]words=new string[numberOfWords];

            //loop to take words input
            for(int i=0; i<numberOfWords; i++)
            {
                Console.Write("ENTER WORD: ");
                words[i] = Console.ReadLine();
            }

            //call CountConsistentStrings method
            CountConsistentStrings(allowed, words); 

        }


        //method to count number of consistent strings
        public static void CountConsistentStrings(string allowed, string[] words)
        {
            //dictionary to store allowed characters
            Dictionary<char, bool> allowedMap = new Dictionary<char, bool>();

            //add each allowed character to dictionary
            foreach (char ch in allowed)
            {
                allowedMap[ch] = true;
            }

            //variable to store count of consistent strings
            int count = 0;

            //loop through each word in words array
            foreach (string word in words)
            {
                //assume current word is consistent
                bool isConsistent = true;

                //loop to check each character of the word
                foreach (char ch in word)
                {
                    if (!allowedMap.ContainsKey(ch))
                    {
                        isConsistent = false;
                        break;
                    }
                }

                //if word is consistent then increase count
                if (isConsistent)
                {
                    count++;
                }
            }

            Console.WriteLine("CONSISTENT STRINGS: "+count);
        }
    }
}
