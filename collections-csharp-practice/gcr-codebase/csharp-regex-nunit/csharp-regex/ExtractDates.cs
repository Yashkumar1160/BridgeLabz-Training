//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_regex_nunit.csharp_regex
//{
//    internal class ExtractDates
//    {
//        public static void Main(string[] args)
//        {
//            //text to store dates
//            string text = "12/05/2023, 15/08/2024, and 29/02/2020.";

//            //regex pattern
//            string pattern = @"\b\d{2}/\d{2}/\d{4}\b";

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
