using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_stringbuilder_stringbuffer
{
    internal class Performance
    {
        static void Main()
        {
            //take number of iterations from user
            Console.Write("Enter number of iterations: ");
            int iterations = int.Parse(Console.ReadLine());

            //call method to compare performance
            ComparePerformance(iterations);
        }

        // Method to compare performance of string and StringBuilder
        static void ComparePerformance(int iterations)
        {
            // Measure time taken using string concatenation
            Stopwatch swString = new Stopwatch();
            swString.Start();

            string result = "";
            for (int i = 0; i < iterations; i++)
            {
                result += "a";
            }

            swString.Stop();

            // Measure time taken using StringBuilder
            Stopwatch swBuilder = new Stopwatch();
            swBuilder.Start();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < iterations; i++)
            {
                sb.Append("a");
            }

            swBuilder.Stop();

            // Display performance results
            Console.WriteLine("String Time: " + swString.ElapsedMilliseconds + " ms");
            Console.WriteLine("StringBuilder Time: " + swBuilder.ElapsedMilliseconds + " ms");
        }
    }
}
