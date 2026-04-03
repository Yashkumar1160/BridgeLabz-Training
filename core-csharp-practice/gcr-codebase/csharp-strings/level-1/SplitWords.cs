using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_strings.level_1
{
    internal class SplitWords
    {
        public static void Main(string[] args)
        {
            //take string sentence input
            Console.WriteLine("Enter sentence:");
            string text = Console.ReadLine();

            //call method to get words and their length
            string[,]result=GetWordsWithLength(text);
            //display output
            for(int i = 0;result[i, 0] != null; i++)
            {
                Console.WriteLine(result[i, 0] + " = " + result[i, 1]);
            }
        }
        //Method to calculate string length 
        public static int GetLength(string text)
        {
            int count = 0;
            //count characters
            foreach(char c in text)
            {
                count++;
            }
            return count;

        }
        //Method to split text into words and store word with its length
        public static string[,] GetWordsWithLength(string text)
        {
            //array to store word and length
            string[,] data = new string[10, 2];
            string word = "";
            int row = 0;
            //loop through each character
            foreach(char c in text)
            {
                //if character is not space add to word
                if(c!=' ')
                {
                    word += c;
                }
                //if space found then store the word and its length
                else
                {
                    data[row, 0] = word;
                    data[row, 1] = GetLength(word).ToString();
                    row++;
                    //reset word
                    word = "";
                }
            }
            //store the last word after loop ends
            data[row, 0] = word;
            data[row, 1] = GetLength(word).ToString();
            return data;
        }
    }
}
