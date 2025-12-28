using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.leet_code_codebase
{
    internal class FinalValueAfterOperations
    {
        public static void Main(string[] args)
        {
            //take number of operation input
            Console.WriteLine("Enter number of operations");
            int numberOfOperation = Convert.ToInt32(Console.ReadLine());
            //create string array to store operations
            string[]operations=new string[numberOfOperation];
            //take operation input
            Console.WriteLine("Enter operations");
            for(int i = 0; i < numberOfOperation; i++)
            {
                operations[i] = Console.ReadLine();
            }
            //initialize variable X to 0
            int X = 0;
            for(int i=0;i < numberOfOperation; i++)
            {   //if operation contains ++ then increment X
                if (operations[i].Contains("++"))
                {
                    X++;
                }
                //if operation contains -- decrement X
                else if (operations[i].Contains("--"))
                {
                    X--;
                }
            }
            Console.WriteLine("Final Value: " + X);
        }
    }
}
