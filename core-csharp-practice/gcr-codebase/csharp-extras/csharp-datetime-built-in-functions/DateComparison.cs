using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_extras.csharp_datetime_built_in_functions
{
    internal class DateComparison
    {
        public static void Main(string[] args)
        {
            //take first date input
            Console.WriteLine("Enter first date (yyyy-MM-dd)");
            DateTime firstDate = Convert.ToDateTime(Console.ReadLine());

            //take second date input
            Console.WriteLine("Enter second date (yyyy-MM-dd)");
            DateTime secondDate = Convert.ToDateTime(Console.ReadLine());

            //Compare dates
            int result = DateTime.Compare(firstDate, secondDate);

            if (result < 0)
            {
                Console.WriteLine("First date is Before second date");
            }
            else if (result > 0)
            {
                Console.WriteLine("First date is After second date");
            }
            else
            {
                Console.WriteLine("Both dates are same");
            }

        }
    }
}
