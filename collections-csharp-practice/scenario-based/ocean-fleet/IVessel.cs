using System;
using System.Collections.Generic;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.ocean_fleet
{
    internal interface IVesselUtil
    {
       //method to add vessel performance
        void AddVesselPerformance(Vessel vessel);

        //method to get vessel by vessel id
        Vessel GetVesselById(string vesselId);

        //method to get high performance vessels
        List<Vessel> GetHighPerformanceVessels();
    }
}
