using System;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.future_logistics
{
    internal abstract class GoodsTransport
    {
        //protected attributes
        protected string transportId;
        protected string transportDate;
        protected int transportRating;

        //3-argument constructor
        public GoodsTransport(string transportId, string transportDate, int transportRating)
        {
            this.transportId = transportId;
            this.transportDate = transportDate;
            this.transportRating = transportRating;
        }

        //getters
        public string TransportId => transportId;
        public string TransportDate => transportDate;
        public int TransportRating => transportRating;

        //abstract methods
        public abstract string VehicleSelection();
        public abstract float CalculateTotalCharge();
    }
}
