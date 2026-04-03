using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.level_1
{
    internal class UppercaseConversion
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string text = Console.ReadLine();

            //call the MakeUppercase method
            string uppercase = MakeUppercase(text);
            Console.WriteLine("Using created method : " + uppercase);
            Console.WriteLine("Using inbuilt method : " + text.ToUpper());

        }
        //Method to convert text to uppercase
        public static string MakeUppercase(string text)
        {
            //string to store uppercase letters
            string uppercaseText = "";
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (ch >= 'a' && ch <= 'z')
                {
                    ch = (char)(ch - 32);
                }
                uppercaseText += ch;
            }
            return uppercaseText;
        }
    }
}
