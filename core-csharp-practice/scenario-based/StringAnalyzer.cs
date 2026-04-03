using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenario_based
{
    internal class StringAnalyzer
    {
        public static void Main(string[] args)
        {
            //take paragraph input
            string paragraph = TakeInput();

            //display choices and perform operations
            CheckChoice(paragraph);
        }

        //------------------------------TAKE INPUT-------------------------
        //Method to take paragraph input
        public static string TakeInput()
        {
            //read paragraph 
            Console.WriteLine("ENTER A PARAGRAPH:");

            string paragraph = Console.ReadLine();

            //if string is empty or null
            if (paragraph == "" || paragraph == null)
            {
                Console.WriteLine("INVALID INPUT. Try again");
                return TakeInput();
            }

            //remove extra spaces and return paragraph
            return RemoveExtraSpaces(paragraph);
        }

        //-----------------------------------CHECK CHOICE-----------------------------
        //Method to display and handle user choices
        public static void CheckChoice(string paragraph)
        {
            //infinite loop to display choices
            while (true)
            {

                //display choices
                Console.WriteLine("1. Count words in paragraph");
                Console.WriteLine("2. Find longest word");
                Console.WriteLine("3. Replace word");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Choice: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //call method based on choice
                switch (choice)
                {
                    case 1:
                        //call CountWords method
                        int numberOfWords = CountWords(paragraph);

                        Console.WriteLine("Number of words in paragraph: " + numberOfWords);

                        break;

                    case 2:
                        //call FindLongestWord method
                        string longestWord = FindLongestWord(paragraph);

                        Console.WriteLine("Longest Word: " + longestWord);

                        break;

                    case 3:
                        //call ReplaceWord method
                        Console.WriteLine("ENTER WORD TO REPLACE");

                        string oldWord = Console.ReadLine();

                        Console.WriteLine("ENTER NEW WORD");

                        string newWord = Console.ReadLine();

                        Console.WriteLine("Paragraph after replacing word: ");

                        Console.WriteLine(ReplaceWord(paragraph, oldWord, newWord));

                        break;

                    case 4:
                        //exit from program
                        Console.WriteLine("Exit Successful");

                        return;

                    default:
                        Console.WriteLine("Invalid Choice. Please enter again ");
                        break;

                }
            }

        }

        //----------------------------------------COUNT WORDS------------------------------
        //method to count number of words
        public static int CountWords(string paragraph)
        {
            //variable to store word count
            int count = 0;

            bool insideWord = false;

            //loop through each character in paragraph
            for (int i = 0; i < paragraph.Length; i++)
            {
                //detect start of new word
                if (paragraph[i] != ' ' && insideWord == false)
                {
                    count++;

                    insideWord = true;
                }
                //detect end of word
                else if (paragraph[i] == ' ')
                {
                    //reset flag
                    insideWord = false;
                }
            }
            return count;
        }

        //-----------------------------------REMOVE SPACES-----------------------------
        //method to remove extra spaces
        public static string RemoveExtraSpaces(string paragraph)
        {
            //stores new paragraph 
            string removedSpaces = "";

            //tracks continuous spaces
            bool spaceFound = false;

            //loop through each character
            for (int i = 0; i < paragraph.Length; i++)
            {
                //current character
                char ch = paragraph[i];

                //if character is space
                if (ch == ' ')
                {
                    //add space only if previous character was not space
                    if (!spaceFound)
                    {
                        removedSpaces += ch;

                        spaceFound = true;
                    }
                }
                else
                {
                    //add non space character
                    removedSpaces += ch;

                    spaceFound = false;
                }
            }

            //remove trailing space
            if (removedSpaces.Length > 0 && removedSpaces[removedSpaces.Length - 1] == ' ')
            {
                string temp = "";

                for (int i = 0; i < removedSpaces.Length - 1; i++)
                {
                    temp += removedSpaces[i];
                }

                removedSpaces = temp;
            }
            return removedSpaces;
        }

        //------------------------------------------FIND LONGEST WORD---------------------------------
        //method to find longest word in paragraph
        public static string FindLongestWord(string paragraph)
        {
            //stores longest word
            string longestWord = "";

            //stores current word
            string currentWord = "";

            //loop through paragraph characters
            for (int i = 0; i < paragraph.Length; i++)
            {
                //current word 
                if (paragraph[i] != ' ')
                {
                    currentWord += paragraph[i];
                }
                else
                {
                    //compare both word lengths
                    if (currentWord.Length > longestWord.Length)
                    {
                        longestWord = currentWord;
                    }
                    currentWord = "";
                }
            }
            //check last word
            if (currentWord.Length > longestWord.Length)
            {
                longestWord = currentWord;
            }

            return longestWord;
        }

        //-----------------------------------------------REPLACE WORD---------------------------------------
        //method to replace word with another word
        public static string ReplaceWord(string paragraph, string oldWord, string newWord)
        {
            //stores updated paragraph
            string afterReplacePara = "";

            //stores current word
            string current = "";

            //loop through paragraph
            for (int i = 0; i < paragraph.Length; i++)
            {
                //current word
                if (paragraph[i] != ' ')
                {
                    current += paragraph[i];
                }
                else
                {
                    //compare words using Lowercase method
                    if (Lowercase(current) == Lowercase(oldWord))
                    {
                        afterReplacePara += newWord;
                    }
                    else
                    {
                        afterReplacePara += current;
                    }
                    afterReplacePara += " ";

                    current = "";
                }
            }
            //Last word
            if (Lowercase(current) == Lowercase(oldWord))
            {
                afterReplacePara += newWord;
            }
            else
            {
                afterReplacePara += current;
            }
            return afterReplacePara;
        }

        //------------------------------------LOWERCASE CONVERSION-----------------------------
        //method to convert string to lowercase
        public static string Lowercase(string word)
        {
            //stores lowercase string
            string lowercaseText = "";

            //loop through each character
            for (int i = 0; i < word.Length; i++)
            {
                //current character
                char ch = word[i];

                if (ch >= 'A' && ch <= 'Z')
                {
                    ch = (char)(ch + 32);
                }

                //add character
                lowercaseText += ch;
            }

            return lowercaseText;
        }
    }
}