using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_1
{
    internal class SumUntilZeroOrNegative
    {
        public static void Main(string[] args)
        {
            //initialize array of size 10
            double[] values = new double[10];
            //initialize total variable to 0.0
            double total = 0.0;
            //initialize index variable to 0;
            int index = 0;

            //using infinite while loop
            while (true)
            {
                //take user input
                Console.WriteLine("Enter Number:");
                double number = Convert.ToDouble(Console.ReadLine());

                //check if the number entered is positive, negative or zero
                if (number < 0 || number == 0)
                {
                    //if number entered is negative or zero
                    break;
                }
                else if (index == 10)
                {   //if index reaches a value of 10
                    break;
                }
                else
                {   //add number to values array
                    values[index] = number;
                    index++;
                }

            }

            //for loop to add the elements from values array 
            for (int i = 0; i < index; i++)
            {
                //add values array element to total
                total += values[i];
            }
            Console.WriteLine("Total is :" + total);
        }
    }
}
