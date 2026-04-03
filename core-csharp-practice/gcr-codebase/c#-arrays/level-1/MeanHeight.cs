using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_1
{
    internal class MeanHeight
    {
        public static void Main(string[] args)
        {
            //create double array heights of size 11
            double[] heights = new double[11];
            //initialize sum variable as 0.0
            double sum = 0.0;

            for (int i = 0; i < heights.Length; i++)
            {   //take height inputs
                Console.WriteLine("Enter Height:");
                heights[i] = Convert.ToDouble(Console.ReadLine());
                //finding sum of all the heights
                sum += heights[i];
            }

            //calculating mean height
            double meanHeight = sum / 11;
            Console.WriteLine("Mean height is :" + meanHeight);


        }
    }
}
