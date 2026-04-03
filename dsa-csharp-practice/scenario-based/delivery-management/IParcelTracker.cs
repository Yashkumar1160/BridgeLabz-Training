using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.delivery_management
{
    internal interface IParcelTracker
    {
        //method to add delivery stage
        public void AddDeliveryStage(Parcel parcel);

        //method to add check point stage
        public void AddCheckPoint();

        //method to track parcel
        public void TrackParcel();

        //method to display parcel status
        public void CheckParcelStatus();

        //method to detect lost parcel
        public void DetectLostParcel();

    }
}
