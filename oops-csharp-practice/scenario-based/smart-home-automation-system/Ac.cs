using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system
{
    internal class Ac : Appliance 
    {
        //constructor
        public Ac(string brand,int modelNumber,bool hasRemote,int warranty, double price) : base(brand,modelNumber,hasRemote,warranty,price) { }
    }
}
