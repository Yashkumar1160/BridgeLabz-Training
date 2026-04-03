using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.csharp_string_extras
{
    internal class ReplaceWord
    {
        public static void Main(string[] args)
        {
            //take sentence input
            Console.WriteLine("Enter sentence");
            string sentence = Console.ReadLine();

            //take word input to replace
            Console.WriteLine("Enter word to replace");
            string word = Console.ReadLine();

            //take new word 
            Console.WriteLine("Enter new word");
            string newWord = Console.ReadLine();

            //call WordReplace method
            string replaced = WordReplace(sentence, word, newWord);

            //display result
            Console.WriteLine("After Replacing : " + replaced);
        }
        //Method to replace word
        public static string WordReplace(string sentence, string word, string newWord)
        {   //stringbuilder to store new sentence
            StringBuilder newSentence = new StringBuilder();
            //index variable to traverse sentence
            int i = 0;
            //loop until sentence end
            while (i < sentence.Length)
            {
                if (i + word.Length <= sentence.Length && sentence.Substring(i, word.Length) == word)
                {
                    newSentence.Append(newWord);
                    i += word.Length;
                }
                else
                {
                    newSentence.Append(sentence[i]);
                    i++;
                }
            }
            return newSentence.ToString();
        }
    }
}
