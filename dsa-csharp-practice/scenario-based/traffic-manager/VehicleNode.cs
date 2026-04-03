using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.traffic_manager
{
    internal class VehicleNode
    {
        //attributes
        public int vehicleNumber;
        public VehicleNode next;

        //constructor
        public VehicleNode(int vehicleNumber)
        {
            this.vehicleNumber = vehicleNumber;
            this.next = null;
        }
    }
}
