using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.traffic_manager
{
    internal interface IRoundabout
    {
        //method to check if roundabout is empty
        bool IsEmpty();

        //method to add vehicle in roundabout
        void AddVehicle(int vehicleNumber);

        //method to remove vehicle from roundabout
        int RemoveVehicle();

        //method to display roundabout state
        public void DisplayRoundabout();
    }       
}
