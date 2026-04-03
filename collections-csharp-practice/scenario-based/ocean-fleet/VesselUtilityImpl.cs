using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.ocean_fleet
{
    internal class VesselUtilImpl : IVesselUtil
    {
        //list to store vessels
        private List<Vessel> vesselList = new List<Vessel>();

        //method to add vessel performance
        public void AddVesselPerformance(Vessel vessel)
        {
            vesselList.Add(vessel);
        }

        //method to get vessel by vessel id
        public Vessel GetVesselById(string vesselId)
        {
            //loop through vessel list
            foreach (Vessel vessel in vesselList)
            {
                if (vessel.VesselId == vesselId)
                {
                    return vessel;
                }
            }

            //return null if not found
            return null;
        }

        //method to get high performance vessels
        public List<Vessel> GetHighPerformanceVessels()
        {
            List<Vessel> result = new List<Vessel>();
            double maxSpeed = 0;

            //find highest speed
            foreach (Vessel vessel in vesselList)
            {
                if (vessel.AverageSpeed > maxSpeed)
                {
                    maxSpeed = vessel.AverageSpeed;
                }
            }

            //add vessels having highest speed
            foreach (Vessel vessel in vesselList)
            {
                if (vessel.AverageSpeed == maxSpeed)
                {
                    result.Add(vessel);
                }
            }

            return result;
        }
    }
}
