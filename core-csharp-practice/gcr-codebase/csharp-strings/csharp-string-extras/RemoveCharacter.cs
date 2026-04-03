using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.csharp_string_extras
{
    internal class RemoveCharacter
    {
        public static void Main(string[] args)
        {
            //take string input
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();
            //take character input to remove
            Console.WriteLine("Enter character to remove");
            char charToRemove = Console.ReadLine()[0];

            //call RemoveSpecificCharacter method
            string removedCharacter = RemoveSpecificCharacter(text, charToRemove);
            //display result
            Console.WriteLine("New String : " + removedCharacter);

        }
        //Method to remove specific character
        public static string RemoveSpecificCharacter(string text, char charToRemove)
        {
            //string to store new string
            StringBuilder newString = new StringBuilder();
            //loop through each character
            foreach (char c in text)
            {
                if (c != charToRemove)
                {
                    newString.Append(c);
                }
            }
            return newString.ToString();
        }

    }
}
