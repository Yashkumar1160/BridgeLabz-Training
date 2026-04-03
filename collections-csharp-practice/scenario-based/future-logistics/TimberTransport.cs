using System;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.future_logistics
{
    internal class TimberTransport : GoodsTransport
    {
        //attributes
        private float timberWeight;
        private int timberTypeCode;
        private string timberType;
        private float pricePerKilo;
        public string TimberType => timberType;
        public float PricePerKilo => pricePerKilo;


        //7-argument constructor
        public TimberTransport(
            string transportId,
            string transportDate,
            int transportRating,
            float timberWeight,
            int timberTypeCode,
            string timberType,
            float pricePerKilo
        ) : base(transportId, transportDate, transportRating)
        {
            this.timberWeight = timberWeight;
            this.timberTypeCode = timberTypeCode;
            this.timberType = timberType;
            this.pricePerKilo = pricePerKilo;
        }

        //method to select vehicle based on timber weight
        public override string VehicleSelection()
        {
            if (timberWeight < 15)
                return "Truck";
            else if (timberWeight <= 20)
                return "Lorry";
            else
                return "MonsterLorry";
        }

        //method to calculate total transport charge
        public override float CalculateTotalCharge()
        {
            //base price
            float price = timberWeight * pricePerKilo;

            //tax calculation
            float tax = price * 0.18f;

            //discount based on rating
            float discount = 0;
            if (transportRating == 5)
                discount = price * 0.20f;
            else if (transportRating == 4)
                discount = price * 0.10f;

            //vehicle charge based on vehicle type
            float vehicleCharge =
                VehicleSelection().Equals("Truck", StringComparison.OrdinalIgnoreCase) ? 1000 :
                VehicleSelection().Equals("Lorry", StringComparison.OrdinalIgnoreCase) ? 1700 : 3000;

            //final charge
            return (price + tax + vehicleCharge) - discount;
        }
    }
}
