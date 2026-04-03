using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.level_1
{
    internal class LowercaseConversion
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();

            //call the MakeLowercase method
            string lowercase = MakeLowercase(text);
            Console.WriteLine("Using created method : " + lowercase);
            Console.WriteLine("Using inbuilt method : " + text.ToLower());

        }
        public static string MakeLowercase(string text)
        {
            //string to store lowercase letters
            string lowercaseText = "";
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (ch >= 'A' && ch <= 'Z')
                {
                    ch = (char)(ch + 32);
                }
                lowercaseText += ch;
            }
            return lowercaseText;
        }
    }
}
