using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.modules
{
    //M-8 City Service Hierarchy
    public class RoutineService : Service
    {
        //Constructor
        public RoutineService(double cost) : base("Routine", cost)
        {
        }

        //override Register method
        public override void Register()
        {
            status = "Registered";
            Console.WriteLine($"{serviceName} service registered");
        }


        //override Cancel method
        public override void Cancel()
        {
            status = "Cancelled";
            Console.WriteLine($"{serviceName} service cancelled");
        }

        public override void DisplayServiceDetails()
        {
            base.DisplayServiceDetails();
        }
    }
}