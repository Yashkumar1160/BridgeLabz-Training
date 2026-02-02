using System;
using System.Text.RegularExpressions;
using System.Reflection;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.future_logistics
{
    internal class FutureUtilityImpl : IFutureLogistics
    {
        //annotation 
        [TransportIdValidationAttribute]
        //method to validate transport id
        public bool ValidateTransportId(string transportId)
        {
            //regex
            return Regex.IsMatch(transportId, @"^RTS[0-9]{3}[A-Z]$");
        }

        //method to parse input string and create object
        public GoodsTransport ParseDetails(string input)
        {
            string[] data = input.Split(':');

            string transportId = data[0];
            string transportDate = data[1];
            int transportRating = int.Parse(data[2]);
            string transportType = data[3];

            //reflection
            MethodInfo method = this.GetType().GetMethod("ValidateTransportId");

            if (method.GetCustomAttribute<TransportIdValidationAttribute>() != null)
            {
                if (!ValidateTransportId(transportId))
                {
                    Console.WriteLine($"Transport id {transportId} is invalid");
                    Console.WriteLine("Please provide a valid record");
                    return null;
                }
            }

            //Brick transport
            if (transportType.Equals("BrickTransport", StringComparison.OrdinalIgnoreCase))
            {
                float brickSize = float.Parse(data[4]);
                int brickQuantity = int.Parse(data[5]);
                float brickPrice = float.Parse(data[6]);

                return new BrickTransport(
                    transportId,
                    transportDate,
                    transportRating,
                    brickSize,
                    brickQuantity,
                    brickPrice
                );
            }

            //Timber transport
            if (transportType.Equals("TimberTransport", StringComparison.OrdinalIgnoreCase))
            {
                float timberWeight = float.Parse(data[4]);
                int timberTypeCode = int.Parse(data[5]);
                string timberType = data[6];
                float pricePerKilo = float.Parse(data[7]);

                return new TimberTransport(
                    transportId,
                    transportDate,
                    transportRating,
                    timberWeight,
                    timberTypeCode,
                    timberType,
                    pricePerKilo
                );
            }

            return null;
        }


        //method to find object type
        public string FindObjectType(GoodsTransport goodsTransport)
        {
            if (goodsTransport is BrickTransport)
            {
                return "BrickTransport";
            }
            else if (goodsTransport is TimberTransport)
            {
                return "TimberTransport";
            }
            else
            {
                return "Unknown";
            }
        }

    }
}
