using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.car_rental_application
{
    internal interface IRentable
    {
        //method to calculate rent
        double CalculateRent(int days);
    }
}
