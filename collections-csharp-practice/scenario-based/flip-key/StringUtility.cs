using System;
using System.Text.RegularExpressions;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.flip_key
{
    internal class StringUtility
    {
        //annotation (only alphabets and min 6 chars)
        [FlipKey("^[a-zA-Z]{6,}$")]
        public string CleanseAndInvert(string input)
        {
            //check for null or length
            if (input == null || input.Length < 6)
            {
                return "";
            }

            //regex validation
            if (!Regex.IsMatch(input, "^[a-zA-Z]{6,}$"))
            {
                return "";
            }

            //convert to lowercase
            input = input.ToLower();

            string filtered = "";

            //loop to remove characters with even ASCII values
            foreach (char ch in input)
            {
                int ascii = (int)ch;

                if (ascii % 2 != 0) 
                {
                    filtered += ch;
                }
            }

            //reverse the string
            char[] arr = filtered.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);

            string result = "";

            //loop to convert even index characters to uppercase
            for (int i = 0; i < reversed.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += char.ToUpper(reversed[i]);
                }
                else
                {
                    result += reversed[i];
                }
            }

            return result;
        }
    }
}
