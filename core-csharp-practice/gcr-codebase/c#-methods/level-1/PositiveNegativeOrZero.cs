using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_1
{
    internal class PositiveNegativeOrZero
    {
        public static void Main(string[] args)
        {
            //take number input
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            //create instance of class
            PositiveNegativeOrZero obj = new PositiveNegativeOrZero();

            //call the CheckPositiveNegativeZero() method
            int checkNumber = obj.CheckPositiveNegativeZero(number);
            //display result
            Console.WriteLine(checkNumber);
        }
        //Method to Check if number is positive, negative or zero
        public int CheckPositiveNegativeZero(int number)
        {
            //check if number is positive negative or zero
            if (number < 0)
            {
                return -1;
            }
            else if (number > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
