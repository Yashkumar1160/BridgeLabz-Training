using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_stringbuilder_stringbuffer
{
    internal class RemoveDuplicates
    {
        public static void Main(string[] args)
        {
            //take string input
            Console.Write("ENTER A STRING: ");
            string stringInput = Console.ReadLine();

            //call FindReverseString method
            string removedDuplicates = RemoveDuplicateCharacters(stringInput);

            Console.Write("REMOVED DUPLICATES: " + removedDuplicates);
        }

        //method to remove duplicate characters
        public static string RemoveDuplicateCharacters(string stringInput)
        {
            //create object of StringBuilder
            StringBuilder result = new StringBuilder();

            //loop through each character
            for (int i = 0; i < stringInput.Length; i++)
            {
                char currentChar = stringInput[i];

                //check if the character already exists in StringBuilder
                if (!ContainsCharacter(result, currentChar))
                {
                    result.Append(currentChar);
                }
            }

            return result.ToString();
        }

        //method to check if a character exists in StringBuilder
        public static bool ContainsCharacter(StringBuilder result, char ch)
        {
            //loop through StringBuilder characters
            for (int i = 0; i < result.Length; i++)
            {
                //if character is found
                if (result[i] == ch)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
