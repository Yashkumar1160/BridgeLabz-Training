//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_regex_nunit.csharp_regex
//{
//    internal class ExtractCapitalizedWords
//    {
//        public static void Main(string[] args)
//        {
//            //text to store all words
//            string text = "Hello World this is A Sentence example.";

//            //regex pattern
//            string pattern = @"\b[A-Z][a-z]*\b";

//            //find all matches
//            MatchCollection matches = Regex.Matches(text, pattern);

//            //display result
//            foreach (Match m in matches)
//            {
//                Console.WriteLine(m.Value);
//            }
//        }
//    }
//}
