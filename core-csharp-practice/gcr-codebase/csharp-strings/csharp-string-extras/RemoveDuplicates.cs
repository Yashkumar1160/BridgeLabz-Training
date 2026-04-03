using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.csharp_string_extras
{
    internal class RemoveDuplicates
    {
        public static void Main(string[] args)
        {
            //take string input
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();
            //call the Remove method
            Console.WriteLine("Text after removing duplicates: " + Remove(text));
        }
        //Method to remove duplicates from string
        public static string Remove(string text)
        {
            //initialize empty string to store unique characters
            string result = "";
            //loop to check present characters in result string
            foreach (char ch in text)
            {
                if (!result.Contains(ch))
                {
                    result += ch;
                }
            }
            return result;
        }
    }
}
