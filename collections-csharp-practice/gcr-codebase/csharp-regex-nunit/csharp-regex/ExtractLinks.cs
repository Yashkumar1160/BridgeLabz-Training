//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_regex_nunit.csharp_regex
//{
//    internal class ExtractLinks
//    {
//        public static void Main(string[] args)
//        {
//            //text to store links
//            string text = "https://www.google.com , http://abcd.org, https://gla.ac.in";

//            //regex pattern
//            string pattern = @"https?://[^\s]+";

//            //find all matches
//            MatchCollection matches = Regex.Matches(text, pattern);

//            //display results
//            foreach (Match m in matches)
//            {
//                Console.WriteLine(m.Value);
//            }
//        }
//    }
//}
