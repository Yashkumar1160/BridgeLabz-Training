using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.core_csharp_practice.leet_code_codebase
{
    internal class AddBinary
    {
        public static void Main(string[] args)
        {
            //take first binary string
            Console.Write("Enter First Binary String: ");
            string a = Console.ReadLine();
            
            //take second binary string
            Console.Write("Enter Second Binary String: ");
            string b = Console.ReadLine();

            //call AddBinaryStrings method 
            string answer = AddBinaryStrings(a, b);

            //convert string to character array
            char[] stringArray = answer.ToCharArray();

            //reverse array
            Array.Reverse(stringArray);

            //empty string
            string reverse = "";

            //loop to add characters
            foreach(char ch in stringArray)
            {
                reverse += ch;
            }
            Console.WriteLine(reverse);
        }

        //method to add two binary strings
        public static string AddBinaryStrings(string a, string b)
        {
            //StringBuilder
            StringBuilder answer = new StringBuilder();

            //pointer for last index of first string
            int i = a.Length - 1;
            
            //pointer for last index of second string
            int j = b.Length - 1;

            //variable to store carry
            int carry = 0;

            //loop through strings
            while (i >= 0 || j >= 0)
            {
                //initialize sum with carry
                int sum = carry;

                //add current bit of first string if exists
                if (i >= 0)
                {
                    sum += a[i--] - '0';
                }

                //add current bit of second string if exists
                if (j >= 0)
                { 
                    sum += b[j--] - '0'; 
                }

                //update carry if sum is greater than 1
                carry = sum > 1 ? 1 : 0;

                answer.Append(sum % 2);
            }
            //if carry remains then append 
            if (carry != 0)
            {
                answer.Append(carry);
            }
            return answer.ToString();
        }
    }
}
