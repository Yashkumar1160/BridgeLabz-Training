using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.csharp_string_extras
{
    internal class PalindromeString
    {
        public static void Main(string[] args)
        {
            //take string input
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();
            //call the CheckPalindrome method
            string isPalindrome = CheckPalindrome(text) ? "Palindrome String" : "Not Palindrome";
            Console.WriteLine(isPalindrome);
        }
        //Method to check palindrome string
        public static bool CheckPalindrome(string text)
        {
            //initialize starting and ending index
            int start = 0;
            int end = text.Length - 1;
            //loop to check characters
            while (start <= end)
            {
                if (text[start] != text[end])
                {
                    return false;
                }
                //increment starting 
                start++;
                //decrement ending index
                end--;
            }
            return true;
        }
    }
}
