//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_regex_nunit.csharp_regex
//{
//    internal class ExtractEmail
//    {
//        public static void Main(string[] args)
//        {
//            //store text with all emails
//            string text = "yashkumar@gmail.com and support@gmail.com and abcdefg@gmail.com";

//            //regex pattern
//            string pattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}";

//            //find all matches
//            MatchCollection matches = Regex.Matches(text, pattern);

//            //loop through matches
//            foreach (Match m in matches)
//            {
//                Console.WriteLine(m.Value);
//            }
//        }
//    }
//}
