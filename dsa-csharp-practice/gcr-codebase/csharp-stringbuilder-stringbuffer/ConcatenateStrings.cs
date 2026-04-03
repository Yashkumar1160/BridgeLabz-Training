using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_stringbuilder_stringbuffer
{
    internal class ConcatenateStrings
    {
        static void Main()
        {
            //take number of strings
            Console.Write("ENTER NUMBER OF STRINGS: ");
            int numberOfStrings = Convert.ToInt32(Console.ReadLine());

            //create array to store strings
            string[] strings = new string[numberOfStrings];

            //loop to take string inputs
            for (int i = 0; i < numberOfStrings; i++)
            {
                Console.Write($"ENTER STRING {i + 1} : ");
                strings[i] = Console.ReadLine();
            }

            //call ConcatenateUsingStringBuilder method
            string result = ConcatenateUsingStringBuilder(strings);

            //display result
            Console.WriteLine("CONCATENATED STRINGS: " + result);
        }

        //method to concatenate array of strings using StringBuilder
        public static string ConcatenateUsingStringBuilder(string[] arr)
        {
            //create object of StringBuilder
            StringBuilder result = new StringBuilder();

            //append each string to StringBuilder
            for (int i = 0; i < arr.Length; i++)
            {
                result.Append(arr[i]);
            }

            return result.ToString();
        }
    }
}
