using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.custom_caching_system
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            //first call 
            Console.WriteLine(calculator.ExecuteWithCache("Square", 5));

            //second call with same input 
            Console.WriteLine(calculator.ExecuteWithCache("Square", 5));

            //different input 
            Console.WriteLine(calculator.ExecuteWithCache("Square", 6));
        }
    }
}
