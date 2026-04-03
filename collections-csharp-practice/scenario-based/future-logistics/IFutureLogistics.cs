using System;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.future_logistics
{
    internal interface IFutureLogistics
    {
        //method to validate transport id using regex and annotation
        bool ValidateTransportId(string transportId);

        //method to parse input string and return GoodsTransport object
        GoodsTransport ParseDetails(string input);

        //method to identify the GoodsTransport type
        string FindObjectType(GoodsTransport goodsTransport);
    }
}
