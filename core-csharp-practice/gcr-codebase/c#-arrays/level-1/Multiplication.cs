using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_1
{
    internal class Multiplication
    {
        public static void Main(string[] args)
        {
            //take number input
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());
            //define integer array multiplicationResult
            int[] multiplicationResult = new int[4];
            //initialize index variable to 0
            int index = 0;
            //find the multiplication 
            for (int i = 6; i <= 9; i++)
            {
                multiplicationResult[index++] = number * i;
            }
            index = 0;
            //display table
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine(number + " * " + i + " = " + multiplicationResult[index++]);
            }
        }
    }
}
