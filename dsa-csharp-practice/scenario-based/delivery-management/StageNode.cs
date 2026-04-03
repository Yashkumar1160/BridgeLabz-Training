using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.delivery_management
{
    internal class StageNode
    {
        //attributes
        public Parcel parcel;
        public string stage;
        public StageNode Next;

        //constructor
        public StageNode(Parcel parcel, string stage)
        {
            this.parcel = parcel;
            this.stage = stage;
            Next = null;
        }
    }
}
