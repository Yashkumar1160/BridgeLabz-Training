using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_extras.csharp_built_in_functions
{
    internal class PalindromeString
    {
        public static void Main(string[] args)
        {
            //take string input
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();

            //call the CheckPalindrome method
            Console.WriteLine(CheckPalindrome(text) ? "Palindrome" : "Not Palindrome");

        }

        //Method to check if a string is palindrome
        public static bool CheckPalindrome(string text)
        {
            //update text to lowercase
            text = text.ToLower();
            int start = 0;
            int end = text.Length - 1;
            //loop until start index is less than or equal to end index
            while (start <= end)
            {
                if (text[start] != text[end])
                {   //if character at starting index is not equal to character at ending index
                    return false;
                }
                //increment starting index
                start++;
                //decrement ending index
                end--;
            }
            return true;
        }
    }
}
