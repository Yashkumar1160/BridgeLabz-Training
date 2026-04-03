using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.scenario_based
{
    //STRING FORMATTER - 29-12-2025
    internal class StringFormatter
    {
        public static void Main(string[] args)
        {
            //take input paragraph and format it correctly
            TakeParagraph();

        }
        //---------------------------------------TAKE PARAGRAPH-----------------------------

        //method to take paragraph input and call different methods to format is 
        public static void TakeParagraph()
        {
            //take input paragraph
            Console.WriteLine("ENTER PARAGRAPH:");
            string originalParagraph = Console.ReadLine();

            if (originalParagraph == null || originalParagraph.Length == 0)
            {
                Console.WriteLine("EMPTY INPUT");

                return;
            }

            //call RemoveSpaces method to remove extra spaces
            string trimmedParagraph = RemoveSpaces(originalParagraph);

            //call CapitalizeLetters to capitalize first letter
            string capitalizedLetters = CapitalizeLetters(trimmedParagraph);

            Console.WriteLine("FORMATTED PARAGRAPH: \n" + capitalizedLetters);

        }

        //----------------------------------CAPITALIZE LETTERS----------------------------

        //method to capitalize first letters  
        public static string CapitalizeLetters(string paragraph)
        {
            //string variable to store paragraph with capitalized letters
            string capitalizedPara = "";

            //initialize capitalized variable to true
            bool capitalized = true;

            //loop through paragraph string
            for (int i = 0; i < paragraph.Length; i++)
            {
                char ch = paragraph[i];

                //if character is in lowercase
                if (capitalized && IsLowerCase(ch))
                {
                    //convert character to uppercase
                    ch = ConvertToUppercase(ch);

                    capitalized = false;
                }

                //add character
                capitalizedPara += ch;

                //if punctuation is found
                if (CheckPunctuation(ch))
                {
                    capitalized = true;

                    //add space only when required
                    if (i + 1 < paragraph.Length && paragraph[i + 1] != ' ')
                    {
                        capitalizedPara += ' ';
                    }
                }
            }
            return capitalizedPara;
        }

        //-------------------------------------REMOVE SPACES-------------------------------

        //method to remove extra spaces
        public static string RemoveSpaces(string originalParagraph)
        {
            //if string is null or empty return
            if (originalParagraph == null || originalParagraph.Length == 0)
            {
                return "";
            }

            //initialize trimmedPara with empty string
            string trimmedPara = "";

            bool spaceFound = false;

            //loop through characters of originalParagraph
            for (int i = 0; i < originalParagraph.Length; i++)
            {
                char ch = originalParagraph[i];

                //allow only one space 
                if (ch == ' ')
                {
                    if (!spaceFound)
                    {
                        trimmedPara += ch;

                        spaceFound = true;
                    }
                }
                else
                {
                    trimmedPara += ch;

                    spaceFound = false;
                }
            }

            //remove trailing spaces 
            if (trimmedPara.Length > 0 && trimmedPara[trimmedPara.Length - 1] == ' ')
            {
                string temp = "";

                for (int i = 0; i < trimmedPara.Length - 1; i++)
                {
                    temp += trimmedPara[i];
                }

                trimmedPara = temp;
            }
            return trimmedPara;
        }

        //----------------------------------CONVERT TO UPPERCASE LETTERS----------------------------

        //method to convert lowercase to uppercase
        public static char ConvertToUppercase(char ch)
        {
            return (char)(ch - 32);
        }

        //----------------------------------CHECK  LOWERCASE ----------------------------

        //method to check lowercase letter
        public static bool IsLowerCase(char ch)
        {
            return ch >= 'a' && ch <= 'z';
        }

        //----------------------------------CHECK SENTENCE END----------------------------

        //method to check ending punctuations
        public static bool CheckPunctuation(char ch)
        {
            return ch == '.' || ch == '?' || ch == '!';
        }

    }
}
