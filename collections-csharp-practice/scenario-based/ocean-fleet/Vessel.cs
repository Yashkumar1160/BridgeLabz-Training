using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.ocean_fleet
{
    internal class Vessel
    {
        //property to store vessel id
        public string VesselId { get; set; }

        //property to store vessel name
        public string VesselName { get; set; }

        //property to store average speed (in knots)
        public double AverageSpeed { get; set; }

        //property to store vessel type
        public string VesselType { get; set; }

        //constructor without argument
        public Vessel() { }

        //four-argument constructor
        public Vessel(string vesselId, string vesselName, double averageSpeed, string vesselType)
        {
            VesselId = vesselId;
            VesselName = vesselName;
            AverageSpeed = averageSpeed;
            VesselType = vesselType;
        }
    }
}
