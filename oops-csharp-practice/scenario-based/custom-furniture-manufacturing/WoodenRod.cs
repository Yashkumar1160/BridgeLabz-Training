using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.custom_furniture_manufacturing
{
    internal class WoodenRod
    {
        //variable to store rod length
        private int rodLength;

        //getter for rod length
        public int GetLength
        {
            get { return rodLength; }
        }

        //constructor
        public WoodenRod(int rodLength)
        {
            this.rodLength = rodLength;
        }
    }
}
