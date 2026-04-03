using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.metal_factory_pipe_cutting
{
    internal class MetalRod
    {
        //variable to store rod length
        private int length;

        //getter for rod length
        public int Length
        {
            get { return length; } 
        }

        //constructor
        public MetalRod(int length)
        {
            this.length = length;
        }

    }
}
