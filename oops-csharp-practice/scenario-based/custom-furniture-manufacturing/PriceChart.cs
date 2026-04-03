using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.custom_furniture_manufacturing
{
    internal class PriceChart
    {
        //array to store prices
        private int[] prices;

        //constructor
        public PriceChart(int maxLength)
        {
            prices= new int[maxLength+1];
        }

        //setter for prices
        public void SetPrice(int length,int price)
        {
            prices[length] = price;
        }

        //getter for prices
        public int GetPrice(int length)
        {
            return prices[length];
        }
    }
}
