using System;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.future_logistics
{
    internal class BrickTransport : GoodsTransport
    {
        //attributes
        private float brickSize;
        private int brickQuantity;
        private float brickPrice;
        public int BrickQuantity => brickQuantity;
        public float BrickPrice => brickPrice;


        //6-argument constructor
        public BrickTransport(
            string transportId,
            string transportDate,
            int transportRating,
            float brickSize,
            int brickQuantity,
            float brickPrice
        ) : base(transportId, transportDate, transportRating)
        {
            this.brickSize = brickSize;
            this.brickQuantity = brickQuantity;
            this.brickPrice = brickPrice;
        }

        //method to select vehicle based on quantity
        public override string VehicleSelection()
        {
            if (brickQuantity < 300)
            {
                return "Truck";
            }
            else if (brickQuantity <= 500)
            {
                return "Lorry";
            }
            else
            {
                return "MonsterLorry";
            }

        }

        //method to calculate total charge
        public override float CalculateTotalCharge()
        {
            float price = brickPrice * brickQuantity;
            float tax = price * 0.3f;

            float discount = 0;
            if (transportRating == 5)
                discount = price * 0.20f;
            else if (transportRating == 3 || transportRating == 4)
                discount = price * 0.10f;

            float vehiclePrice =
                VehicleSelection().Equals("Truck", StringComparison.OrdinalIgnoreCase) ? 1000 :
                VehicleSelection().Equals("Lorry", StringComparison.OrdinalIgnoreCase) ? 1700 : 3000;

            return (price + tax + vehiclePrice) - discount;
        }
    }
}

