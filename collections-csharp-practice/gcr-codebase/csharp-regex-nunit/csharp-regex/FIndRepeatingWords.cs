//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_regex_nunit.csharp_regex
//{
//    internal class FIndRepeatingWords
//    {
//        public static void Main(string[] args)
//        {
//            //store sentence with repeating words
//            string text = "this is is a a sentence with with repeating words.";

//            //regex pattern
//            string pattern = @"\b(\w+)\s+\1\b";

//            //find all matches
//            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

//            //display results
//            foreach (Match m in matches)
//            {
//                Console.WriteLine(m.Groups[1].Value);
//            }
//        }
//    }
//}
