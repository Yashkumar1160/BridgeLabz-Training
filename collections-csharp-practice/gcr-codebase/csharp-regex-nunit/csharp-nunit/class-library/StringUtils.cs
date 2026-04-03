using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_library
{
    public class StringUtils
    {
        //method to reverse a string
        public string Reverse(string str)
        {
            //convert string to char array
            char[] chars = str.ToCharArray();

            //reverse the char array
            Array.Reverse(chars);

            //convert char array back to string
            return new string(chars);
        }

        //method to check palindrome
        public bool IsPalindrome(string str)
        {
            //reverse the string
            string reversed = Reverse(str);

            //compare original and reversed string
            return str.Equals(reversed);
        }

        //method to convert string to uppercase
        public string ToUpperCase(string str)
        {
            //convert string to uppercase
            return str.ToUpper();
        }
    }
}
