using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.level_1
{
    internal class Substring
    {
        public static void Main(string[] args)
        {
            //take user input string
            Console.WriteLine("Enter String");
            string text = Console.ReadLine();
            //take user input starting index
            Console.WriteLine("Enter starting index");
            int startIndex = Convert.ToInt32(Console.ReadLine());
            //take user input ending index
            Console.WriteLine("Enter ending index");
            int endIndex = Convert.ToInt32(Console.ReadLine());

            //call the FindSubstring() method
            string subString = FindSubstring(text, startIndex, endIndex);
            Console.WriteLine("Substring using FindSubstring method : " + subString);

            //call the Substring() method
            int length = endIndex - startIndex;
            string substr = text.Substring(startIndex, length);
            Console.WriteLine("Substring using Substring method : " + substr);

            //compar both methods
            if (substr.Equals(subString))
            {   //if both methods returns same substring
                Console.WriteLine("Both are same");
            }
            else
            {   //if both method returns different substring
                Console.WriteLine("Both are different");
            }

        }
        //Method to find substring
        public static string FindSubstring(string text, int startIndex, int endIndex)
        {
            //find substring
            string subString = "";
            for (int i = startIndex; i < endIndex; i++)
            {
                subString += text[i];
            }
            return subString;
        }
    }
}
