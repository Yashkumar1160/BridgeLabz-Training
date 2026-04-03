using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.metal_factory_pipe_cutting
{
    internal class Utility : ICalculate
    {
        //initialize objects with null 
        static PriceChart priceChart = null;
        static MetalRod metalRod = null;

        //recursive method to find maximum revenue
        public int FindMaximum(int rodLength, PriceChart priceChart)
        {
            //if rod length is less than or equal to 0
            if (rodLength <= 0)
            {
                return 0;
            }

            //assume max revenue
            int maxRevenue = 0;

            //loop to find price of cutting lengths and find max revenue
            for (int i = 1; i <= rodLength; i++)
            {
                //recursive call
                int revenueGenerated = priceChart.GetPrice(i) + FindMaximum(rodLength - i, priceChart);

                //if revenue generated is greater than max revenue 
                if (revenueGenerated > maxRevenue)
                {
                    //update max revenue
                    maxRevenue = revenueGenerated;
                }
            }

            return maxRevenue;
        }


        //method to add prices chart
        public static void AddPrices()
        {
            //take rod length
            Console.WriteLine("ENTER ROD LENGTH: ");

            //create object 
            metalRod = new MetalRod(Convert.ToInt32(Console.ReadLine()));

            //create object of PriceChart
            priceChart = new PriceChart(metalRod.Length); 

            //loop to take prices input
            for (int i = 1; i <= metalRod.Length; i++)
            {
                Console.Write($"ENTER PRICE FOR LENGTH {i} :");
                int price = Convert.ToInt32(Console.ReadLine());
                priceChart.SetPrice(i, price);
            }
        }


        //method to find best cuts 
        public static void FindBestRevenue()
        {
            //check if price chart is present
            if (priceChart == null)
            {
                Console.WriteLine("ADD PRICE CHART FIRST");
                return;
            }
            
            //create object of Utility class
            Utility utility = new Utility();

            //call FindMaximum method and display result
            int maximum = utility.FindMaximum(metalRod.Length, priceChart);
            Console.WriteLine("MAXIMUM OPTIMIZED REVENUE: " + maximum);
        }


        //method to find revenue with custom length prices
        public static void CustomLengthPrice()
        {
            //check if price chart is present
            if (priceChart == null)
            {
                Console.WriteLine("ADD PRICE CHART FIRST.");
                return;
            }

            //check if metal rod exists
            if (metalRod == null)
            {
                Console.WriteLine("ENTER ROD LENGTH: ");
                metalRod= new MetalRod(Convert.ToInt32(Console.ReadLine()));
            }

            //take length whose price is to be changed
            Console.Write("\nENTER LENGTH: ");
            int changingLength = Convert.ToInt32(Console.ReadLine());

            //if changing length is greater than metal rod length
            if (changingLength > metalRod.Length)
            {
                Console.WriteLine("INVALID LENGTH");
                return;
            }

            //take new price
            Console.Write("ENTER NEW PRICE: ");
            int newPrice = Convert.ToInt32(Console.ReadLine());

            //set new price
            priceChart.SetPrice(changingLength, newPrice);

            Utility utility = new Utility();

            utility.FindMaximum(metalRod.Length, priceChart);
        }


        //method to find revenue without optimized solution
        public static void NotOptimized()
        {
            //check if price chart exists
            if (priceChart == null)
            {
                Console.WriteLine("ADD PRICE CHART FIRST.");
                return;
            }

            //check if metal rod exists
            if (metalRod == null)
            {
                Console.WriteLine("ENTER ROD LENGTH: ");
                metalRod = new MetalRod(Convert.ToInt32(Console.ReadLine()));
            }

            //take random length cuts
            Random random = new Random();
            int length1 = random.Next(1, metalRod.Length);
            int length2 = metalRod.Length - length1;

            //find revenue based on random cuts
            int revenue = priceChart.GetPrice(length1) + priceChart.GetPrice(length2);

            Console.WriteLine("NON-OPTIMIZED REVENUE: " + revenue);
        }
    }
}