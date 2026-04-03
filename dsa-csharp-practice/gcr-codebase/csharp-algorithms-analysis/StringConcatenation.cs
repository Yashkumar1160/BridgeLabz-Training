using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_algorithms_analysis
{
    internal class StringConcatenation
    {
        public static void Main(string[] args)
        {
            //start time for string
            DateTime stringStart = DateTime.Now;

            //string to store result 
            string result = "";

            //loop through characters 
            for (int i = 0; i < 1000; i++)
            {
                result = result + "A";
            }

            //end time for string
            DateTime stringEnd = DateTime.Now;

            //display result
            Console.WriteLine("\nLENGTH: " + result.Length);
            Console.WriteLine("STRING TIME: " +(stringEnd - stringStart).TotalMilliseconds + " ms");


            //start time for string builder
            DateTime sbStart = DateTime.Now;

            //create string builder object
            StringBuilder sb = new StringBuilder();

            //loop through characters
            for (int i = 0; i < 1000; i++)
            {
                //append character in sb
                sb.Append("A");
            }

            //end time for string builder
            DateTime sbEnd = DateTime.Now;

            //display result
            Console.WriteLine("\nLENGTH: " + sb.Length);
            Console.WriteLine("StringBuilder TIME: " +(sbEnd - sbStart).TotalMilliseconds + " ms");
        }
    }
}
