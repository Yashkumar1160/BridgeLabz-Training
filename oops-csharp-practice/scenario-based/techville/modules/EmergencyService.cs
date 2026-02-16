using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.modules
{
    //M-8 City Service Hierarchy
    public class EmergencyService : Service
    {
        //constructor
        public EmergencyService(double cost): base("Emergency Service", cost)
        {
        }

        //override Register method
        public override void Register()
        {
            status = "Emergency";
            Console.WriteLine("Emergency service is Available");
        }
    }
}