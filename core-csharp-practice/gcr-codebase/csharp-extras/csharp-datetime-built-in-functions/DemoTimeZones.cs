using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_extras.csharp_datetime_built_in_functions
{
    internal class DemoTimeZones
    {
        public static void Main(string[] args)
        {
            //get current UTC time
            DateTimeOffset utcTime = DateTimeOffset.UtcNow;

            //display GMT time
            Console.WriteLine("GMT Time: " + utcTime);

            //get IST time zone
            TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, istZone);
            Console.WriteLine("IST Time: " + istTime);

            //get PST time zone
            TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pstZone);
            Console.WriteLine("PST Time: " + pstTime);
        }
    }
}
