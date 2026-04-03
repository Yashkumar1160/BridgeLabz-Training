using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.delivery_management
{
    internal class ParcelTrackerUtilityImpl : IParcelTracker 
    {
        //create objecy of ParcelTracker class
        ParcelTracker parcelTracker = new ParcelTracker();


        //method to add delivery stage
        public void AddDeliveryStage(Parcel parcel)
        {
            //take stage
            Console.Write("\nENTER STAGE: ");
            string stage=Console.ReadLine();

            //add delivery stage to list
            parcelTracker.AddDeliveryStage(parcel,stage);
        }


        //method to add a check point stage
        public void AddCheckPoint()
        {
            //take after stage
            Console.Write("\nENTER AFTER STAGE: ");
            string afterStage=Console.ReadLine();


            //take checkpoint stage
            Console.Write("ENTER CHECKPOINT: ");
            string checkpointStage=Console.ReadLine();

            //add checkpoint stage
            parcelTracker.AddCheckpoint(afterStage,checkpointStage);
        }

        
        //method to track parcel
        public void TrackParcel()
        {
            parcelTracker.TrackParcel();
        }


        //method to check parcel status
        public void CheckParcelStatus()
        {
            parcelTracker.CheckParcelStatus();
        }


        //method to detect lost parcel
        public void DetectLostParcel()
        {
            parcelTracker.FindLostParcel();
        }

    }
}
