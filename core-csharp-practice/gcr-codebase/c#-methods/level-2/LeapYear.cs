using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_2
{
    internal class LeapYear
    {
        public static void Main(string[] args)
        {
            //take input year
            Console.WriteLine("Enter Year:");
            int year = Convert.ToInt32(Console.ReadLine());

            //call the CheckLeapYear() method
            bool isLeapYear = CheckLeapYear(year);

            //display result
            Console.WriteLine("Year is a Leap year : " + isLeapYear);
        }
        //Method to check leap year
        public static bool CheckLeapYear(int year)
        {
            //check if year is a leap year
            if (year < 1582)
            {
                return false;
            }
            else if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
