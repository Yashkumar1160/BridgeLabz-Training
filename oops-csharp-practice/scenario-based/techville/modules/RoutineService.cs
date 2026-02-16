using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.modules
{
    //M-8 City Service Hierarchy
    public class RoutineService:Service
    {
        //Constructor
        public RoutineService(double cost): base("Routine Service", cost)
        {
        }

        //override Register method
        public override void Register()
        {
            status = "Routine Service Scheduled.";
            Console.WriteLine("Routine service registered.");
        }
    }
}