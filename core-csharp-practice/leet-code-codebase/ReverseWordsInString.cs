using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.core_csharp_practice.leet_code_codebase
{
    internal class ReverseWordsInString
    {
        public static void Main()
        {
            //take input string from user
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            //call method to reverse words
            string result = ReverseWords(input);

            //print reversed string
            Console.WriteLine("Reversed string:");
            Console.WriteLine(result);
        }

        //method to reverse words in string
        static string ReverseWords(string s)
        {
            //trim leading and trailing spaces
            s = s.Trim();

            //split string using space character
            string[] words = s.Split(' ');

            //string to store final result
            string result = "";

            //loop from last word to first
            for (int i = words.Length - 1; i >= 0; i--)
            {
                //skip empty strings caused by multiple spaces
                if (words[i] == "")
                    continue;

                //add word to result
                result += words[i] + " ";
            }

            //remove extra space at the end
            result = result.Trim();

            //return final reversed string
            return result;
        }
    }
}
