using System;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.future_logistics
{
    public class UserInterface
    {
        public static void DisplayMenu()
        {
            //take transport details
            Console.WriteLine("Enter the Goods Transport details");
            string input = Console.ReadLine();

            //create object
            FutureUtilityImpl utility = new FutureUtilityImpl();
            GoodsTransport gt = utility.ParseDetails(input);

            //check if gt is null
            if (gt == null)
            {
                return;
            }

            //display common details
            Console.WriteLine("Transporter id : " + gt.TransportId);
            Console.WriteLine("Date of transport : " + gt.TransportDate);
            Console.WriteLine("Rating of the transport : " + gt.TransportRating);

            //check type and print specific details
            if (gt is BrickTransport)
            {
                BrickTransport bt = (BrickTransport)gt;

                Console.WriteLine("Quantity of bricks : " + bt.BrickQuantity);
                Console.WriteLine("Brick price : " + bt.BrickPrice);
            }
            else if (gt is TimberTransport)
            {
                TimberTransport tt = (TimberTransport)gt;

                Console.WriteLine("Type of the timber : " + tt.TimberType);
                Console.WriteLine("Timber price per kilo : " + tt.PricePerKilo);
            }

            //display final output
            Console.WriteLine("Vehicle for transport : " + gt.VehicleSelection());
            Console.WriteLine("Total charge : " + gt.CalculateTotalCharge());

        }
    }
}
