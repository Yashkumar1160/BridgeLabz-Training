using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.leet_code_codebase
{
    internal class LargestEvenNumber
    {
        public static void Main()
        {
            Console.Write("Enter string (only 1 and 2): ");
            string str = Console.ReadLine();

            string result = FindLargestEvenNumber(str);
            Console.WriteLine("Result: " + result);
        }

        public static string FindLargestEvenNumber(string str)
        {
            int lastTwoIndex = -1;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '2')
                {
                    lastTwoIndex = i;
                }
            }

            if (lastTwoIndex == -1)
                return "";

            return str.Substring(0, lastTwoIndex + 1);
        }
    }
}
