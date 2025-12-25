
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_3
{
    internal class Calendar
    {
        public static void Main(string[] args)
        {
            //take month input
            Console.Write("Enter month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            //take year input
            Console.Write("Enter year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            //display month and year
            Console.WriteLine("\n   " + GetMonthName(month) + " " + year);
            //display week days
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
            //get starting day
            int firstDay = GetFirstDay(month, year);
            //get total days count
            int totalDays = GetDaysInMonth(month, year);

            for (int i = 0; i < firstDay; i++)
            {
                Console.Write("    ");
            }
            //display days
            for (int day = 1; day <= totalDays; day++)
            {
                Console.Write($"{day,3}");
                //move to next line after saturday
                if ((day + firstDay) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

        }
        //Method to check leap year
        public static bool CheckLeapYear(int year)
        {
            //Condition for leap year
            if (year % 400 == 0) return true;
            if (year % 100 == 0) return false;
            if (year % 4 == 0) return true;
            return false;
        }
        //Method to get the month name
        public static string GetMonthName(int month)
        {
            //store month names in array
            string[] months = { "January", "February", "March", "April",
            "May", "June", "July", "August",
            "September", "October", "November", "December"};
            return months[month - 1];
        }
        //Method to get days in month
        public static int GetDaysInMonth(int month, int year)
        {
            //array storing days in each month
            int[] days =
            {
                31,28,31,30,31,30,31,31,30,31,30,31
            };
            //check for february and leap year
            if (month == 2 && CheckLeapYear(year))
            {
                return 29;
            }
            return days[month - 1];
        }
        //Method to get first day of month
        public static int GetFirstDay(int month, int year)
        {
            //first day of month
            int d = 1;
            //using gregorian formula
            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;
            return d0;
        }

    }
}
