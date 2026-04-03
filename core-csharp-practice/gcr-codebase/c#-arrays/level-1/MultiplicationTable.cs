using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_1
{
    internal class MultiplicationTable
    {
        public static void Main(string[] args)
        {
            //take integer number input
            Console.WriteLine("Enter Number:");
            int number = Convert.ToInt32(Console.ReadLine());

            //initialize array with length 10
            int[] table = new int[10];

            //store the results in the multiplication table
            for (int i = 1; i <= 10; i++)
            {
                table[i - 1] = number * i;
            }

            //display the multiplication table
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine(number + " * " + (i + 1) + " = " + table[i]);
            }
        }
    }
}