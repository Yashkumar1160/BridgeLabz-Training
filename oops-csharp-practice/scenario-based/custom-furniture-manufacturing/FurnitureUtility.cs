using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.custom_furniture_manufacturing
{
    internal class FurnitureUtility : ICalculate 
    {
        //initialize 
         PriceChart priceChart=null;

         WoodenRod woodenRod = null;

        //method to add prices to chart
        public void AddPriceChart(int rodLength)
        { 
            //create object 
            woodenRod = new WoodenRod(rodLength);

            //create object 
            priceChart = new PriceChart(woodenRod.GetLength);

            //loop to take prices
            for(int  i = 1; i <= rodLength; i++)
            {
                Console.Write($"ENTER PRICE FOR {i} CUT: ");
                priceChart.SetPrice(i, Convert.ToInt32(Console.ReadLine()));
            }
        }

        //method to find maximum revenue
        public int FindMaxRevenue(int remainingLength)
        {
            //check priceChart and woodenRod object creations
            if (priceChart == null || woodenRod == null)
            {
                Console.WriteLine("PLEASE ADD PRICE CHART FIRST.");
                return 0;
            }

            //base case 
            if (remainingLength <= 0)
            {
                return 0;
            }

            //assume max revenue
            int maxRevenue = 0;

            //loop to find price of cutting lengths and find max revenue
            for (int i = 1; i <= remainingLength; i++)
            {
                //recursive call
                int revenueGenerated = priceChart.GetPrice(i) + FindMaxRevenue(remainingLength - i);

                //if revenue generated is greater than max revenue 
                if (revenueGenerated > maxRevenue)
                {
                    //update max revenue
                    maxRevenue = revenueGenerated;
                }
            }

            return maxRevenue;
        }

        //method to find maximum revenue with minimum waste
        public int FindMaxRevenueWithMinWaste(int length)
        {
            if (priceChart == null || woodenRod == null)
            {
                Console.WriteLine("PLEASE ADD PRICE CHART FIRST.");
                return 0;
            }

            //base case
            if (length <= 0)
                return 0;

            int maxRevenue = 0;
            int minWaste = int.MaxValue;

            //trying all possible cuts
            for (int i = 1; i <= length; i++)
            {
                int remainingLength = length - i;

                //recursive call
                int revenue = priceChart.GetPrice(i)
                              + FindMaxRevenueWithMinWaste(remainingLength);

                int waste = remainingLength;

                //choose better option
                if (revenue > maxRevenue ||
                   (revenue == maxRevenue && waste < minWaste))
                {
                    maxRevenue = revenue;
                    minWaste = waste;
                }
            }

            return maxRevenue;
        }


        //method to find maximum revenue with waste constraint
        public int FindMaxRevenueWithWaste(int remainingLength,int waste)
        {
            //base case if no rod left
            if (remainingLength <= 0)
            {
                return 0;
            }

            //if waste is less than 0
            if (waste < 0)
            {
                return 0;
            }

            //initialize max variable to 0
            int maxRevenue = 0;

            //loop to find all cut sizes
            for (int i = 1; i <= remainingLength; i++)
            {
                int leftover = remainingLength - i;
                int value = priceChart.GetPrice(i) + FindMaxRevenueWithWaste(remainingLength - i, waste - leftover);


                //update max revenue
                if (value > maxRevenue)
                {
                    maxRevenue = value;
                }
            }

            return maxRevenue;
        }

    }
}
