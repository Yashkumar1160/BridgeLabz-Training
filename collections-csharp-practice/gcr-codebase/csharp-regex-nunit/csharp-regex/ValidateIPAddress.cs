//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_regex_nunit.csharp_regex
//{
//    internal class ValidateIPAddress
//    {
//        public static void Main(string[] args)
//        {
//            //store ip address
//            string ip = "192.168.1.1";

//            //regex pattern
//            string pattern =@"^((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)\.){3}" + @"(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)$";

//            //check if pattern matches
//            bool isValid = Regex.IsMatch(ip, pattern);

//            //display results
//            Console.WriteLine(isValid ? "Valid IP" : "Invalid IP");
//        }
//    }
//}
