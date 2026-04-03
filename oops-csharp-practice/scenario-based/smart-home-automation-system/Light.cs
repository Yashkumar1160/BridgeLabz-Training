using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system
{
    internal class Light:Appliance
    {
        //constructor
        public Light(string brand, int modelNumber, bool remote, int warranty,double price) : base(brand, modelNumber, remote, warranty,price) { }
    }
}
