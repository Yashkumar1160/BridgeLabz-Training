using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.level_1
{
    internal class StringCharacters
    {
        public static void Main(string[] args)
        {
            //take string input
            Console.WriteLine("Enter a String:");
            string text = Console.ReadLine();

            Console.WriteLine("Using PrintCharacters() Method:");
            //call the PrintCharacters() method
            PrintCharacters(text);
            Console.WriteLine("Using ToCharArray() method:");
            //create character array to store characters in text
            char[] textArray = text.ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(textArray[i] + " ");
            }


        }
        //Method to print the characters of string
        public static void PrintCharacters(string text)
        {
            Console.WriteLine("Characters are:");
            //loop to print each character of string
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
