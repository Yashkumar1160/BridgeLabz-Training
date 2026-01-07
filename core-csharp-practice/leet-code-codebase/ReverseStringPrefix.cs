using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.leet_code_codebase
{
    internal class ReverseStringPrefix
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string s = Console.ReadLine();

            Console.Write("Enter k: ");
            int k = Convert.ToInt32(Console.ReadLine());

            string result = ReversePrefix(s, k);
            Console.WriteLine("Result: " + result);
        }


        static string ReversePrefix(string s, int k)
        {
            if (k <= 1 || k > s.Length)
                return s;

            char[] chars = s.ToCharArray();

            int left = 0;
            int right = k - 1;

            while (left < right)
            {
                char temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;

                left++;
                right--;
            }

            return new string(chars);
        }
    }
}
