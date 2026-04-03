using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.leet_code_codebase
{
    internal class ReversePrefixOfWord
    {
        public static void Main(string[] args)
        {
            //take word input
            Console.WriteLine("Enter word");
            string word=Console.ReadLine();
            //take character input
            Console.WriteLine("Enter character");
            char ch = Convert.ToChar(Console.ReadLine());
            //find first occurence of character
            int index = word.IndexOf(ch);
            //if character is missing then print original word
            if (index == -1)
            {
                Console.WriteLine("Result: " + word);
                return;
            }
            //convert string to char array
            char[]chars = word.ToCharArray();

            //initialize starting and ending index
            int start = 0;
            int end = index;
            while(start < end)
            {
                //swap characters
                char temp = chars[start];
                chars[start] = chars[end];
                chars[end] = temp;
                //increment and decrement indexes
                start++;
                end--;
            }
            //char array to string
            string result=new string(chars);
            Console.WriteLine(result);
        }
    }
}
