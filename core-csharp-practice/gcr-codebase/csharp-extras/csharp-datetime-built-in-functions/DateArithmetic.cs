using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_extras.csharp_datetime_built_in_functions
{
    internal class DateArithmetic
    {
        public static void Main(string[] args)
        {
            //take date input 
            Console.WriteLine("Enter a date (yyyy-MM-dd)");
            DateTime date = Convert.ToDateTime(Console.ReadLine());

            //add 7 days, 1 month and 2 years
            DateTime newDate = date.AddDays(7).AddMonths(1).AddYears(2);

            //subtract 3 weeks
            newDate = newDate.AddDays(-21);

            Console.WriteLine("New Date is : " + newDate);
        }
    }
}
