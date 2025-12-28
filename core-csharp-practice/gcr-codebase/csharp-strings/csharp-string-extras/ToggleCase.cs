using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.csharp_string_extras
{
    internal class ToggleCase
    {
        public static void Main(string[] args)
        {
            //take string input
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();

            //call the ToggleCharacters method
            string toggleText = ToggleCharacters(text);
            Console.WriteLine("Toggled String: " + toggleText);
        }
        //Method to toggle case using ASCII 
        public static string ToggleCharacters(string text)
        {
            //create a string
            StringBuilder toggle = new StringBuilder();

            foreach (char ch in text)
            {
                //check for uppercase character
                if (ch >= 'A' && ch <= 'Z')
                {   //convert to lowercase
                    toggle.Append((char)(ch + 32));
                }
                //check for lowercase character
                else if (ch >= 'a' && ch <= 'z')
                {   //convert to uppercase
                    toggle.Append((char)(ch - 32));
                }
                //keep other characters same
                else
                {
                    toggle.Append(ch);
                }
            }
            return toggle.ToString();
        }
    }
}
