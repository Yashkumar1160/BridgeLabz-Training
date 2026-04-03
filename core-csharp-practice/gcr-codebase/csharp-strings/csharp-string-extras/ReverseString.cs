using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.csharp_string_extras
{
    internal class ReverseString
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter a string:");
            string text = Console.ReadLine();
            //call method to reverse string
            Console.WriteLine(ReverseText(text));
        }
        //Method to reverse string
        public static string ReverseText(string text)
        {
            //initialize empty string
            string reverse = "";
            //loop to add characters to reverse string
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverse += text[i];
            }
            return reverse;
        }
    }

}
