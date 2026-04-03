using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system
{
    internal interface IControllable
    {
        //method to turn on appliance
        void TurnOn(Appliance appliance);

        //method to turn off appliance
        void TurnOff(Appliance appliance);
    }
}
