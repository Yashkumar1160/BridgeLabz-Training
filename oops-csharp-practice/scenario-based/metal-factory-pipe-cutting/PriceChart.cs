using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.metal_factory_pipe_cutting
{
    internal class PriceChart
    {
        //array to store prices of cutting length
        int[] prices;

        //constructor
        public PriceChart(int maxLength)
        {
            prices=new int[maxLength+1];
        }
        
        //set price
        public void SetPrice(int length,int newPrice)
        {
            prices[length] = newPrice;
        }

        //get price
        public int GetPrice(int length)
        {
            return prices[length];
        }
    }
}
