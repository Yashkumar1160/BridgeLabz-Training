using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_extras.csharp_datetime_built_in_functions
{
    internal class DateFormatting
    {
        public static void Main(string[] args)
        {
            //get current date and time 
            DateTime currentDate = DateTime.Now;

            //display dates in different formats
            Console.WriteLine("dd/mm/yyyy Format: " + currentDate.ToString("dd/MM/yyyy"));
            Console.WriteLine("yyyy-mm-dd Format: " + currentDate.ToString("yyyy-MM-dd"));
            Console.WriteLine("EEE,MMM,dd,yyyy Format: " + currentDate.ToString("ddd,MMM,dd,yyyy"));

        }
    }
}
