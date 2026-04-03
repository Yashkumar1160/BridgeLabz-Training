//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_regex_nunit.csharp_regex
//{
//    internal class ExtractCurrencyValues
//    {
//        public static void Main(string[] args)
//        {
//            //store sentence with currency 
//            string text = "The prices are $45.99,$ 10.50 and $50.";

//            //regex pattern
//            string pattern = @"\$?\s?\d+\.\d{2}";

//            //find all matches
//            MatchCollection matches = Regex.Matches(text, pattern);

//            //display results
//            foreach (Match m in matches)
//            {
//                Console.WriteLine(m.Value.Trim());
//            }
//        }
//    }
//}
