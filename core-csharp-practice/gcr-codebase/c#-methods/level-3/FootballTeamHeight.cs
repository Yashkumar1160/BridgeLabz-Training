using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_3
{
    internal class FootballTeamHeight
    {
        //Method to calculate sum of heights
        public static int FindSum(int[] heights)
        {
            //initialize sum variable
            int sum = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                //add each height
                sum += heights[i];
            }
            //return sum
            return sum;
        }
        //Method to calculate mean of heights
        public static double FindMean(int[] heights)
        {
            //find sum of heights
            int sum = FindSum(heights);
            //find mean height
            double mean =(double)sum / heights.Length;
            //return mean
            return mean;
        }
        //Method to find shortest height
        public static int FindShortest(int[] heights)
        {
            //take first height as minimum
            int min = heights[0];
            //loop to find minimum height
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] < min)
                {
                    min = heights[i];
                }
            }
            return min;
        }
        //Method to find tallest height
        public static int FindTallest(int[] heights)
        {
            //take first height as maximum
            int max = heights[0];
            //loop to find tallest height
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > max)
                {
                    max = heights[i];
                }
            }
            return max;
        }
        //Main method
        public static void Main(string[] args)
        {
            //array to store heights
            int[] heights = new int[11];
            //create object of Random class
            Random random = new Random();

            //generate random heights
            for (int i = 0; i < heights.Length; i++)
            {
                heights[i] = random.Next(150, 250);
                Console.WriteLine("Player " + (i + 1) + " Height: " + heights[i]);
            }
            //display result
            Console.WriteLine("Shortest Height: " + FindShortest(heights));
            Console.WriteLine("Tallest Height: " + FindTallest(heights));
            Console.WriteLine("Mean Height: " + FindMean(heights));

        }


    }
}
