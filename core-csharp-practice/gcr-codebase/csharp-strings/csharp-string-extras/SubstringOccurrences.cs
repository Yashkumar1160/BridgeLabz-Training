using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.csharp_string_extras
{
    internal class SubstringOccurrences
    {
        static void Main(string[] args)
        {
            //take main string input
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();

            //take substring input
            Console.WriteLine("Enter substring");
            string subString = Console.ReadLine();

            //call the CountOccurrences method
            int count = CountOccurrences(text, subString);

            //display result
            Console.WriteLine("Substring occurs " + count + " times");
        }
        //Method to count substring occurrences
        static int CountOccurrences(string text, string subString)
        {   //initialize count and index variable with 0
            int count = 0;
            int index = 0;

            //loop until substring is found
            while ((index = text.IndexOf(subString, index)) != -1)
            {   //increase count
                count++;
                //move index
                index += subString.Length;
            }
            return count;
        }
    }
}
