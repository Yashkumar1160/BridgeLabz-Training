using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.ranksheet_generator
{
    internal class State
    {
        string stateName;
        ArrayList districts;

        public string StateName { get; set; }

        public ArrayList Districts { get; set; }

        public State(string stateName)
        {
            StateName = stateName;
            Districts = new ArrayList();
        }
    }
}
