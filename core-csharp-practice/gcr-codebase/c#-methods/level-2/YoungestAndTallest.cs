using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_2
{
    internal class YoungestAndTallest
    {
        public static void Main(string[] args)
        {
            //create arrays to store names, ages and heights
            string[] names = { "Amar", "Akbar", "Anthony" };
            int[] ages = new int[3];
            double[] heights = new double[3];
            //take user inputs
            for (int i = 0; i < 3; i++)
            {
                //take input age
                Console.WriteLine("Enter age of " + names[i]);
                ages[i] = Convert.ToInt32(Console.ReadLine());
                //take input height
                Console.WriteLine("Enter height of " + names[i]);
                heights[i] = Convert.ToDouble(Console.ReadLine());


            }
            Console.WriteLine("Youngest is : " + names[FindYoungest(ages)]);
            Console.WriteLine("Tallest is : " + names[FindTallest(heights)]);
        }
        //Method to find youngest
        public static int FindYoungest(int[] ages)
        {
            int minIndex = 0;
            for (int i = 1; i < ages.Length; i++)
            {
                if (ages[i] < ages[minIndex])
                {
                    minIndex = i;
                }
            }
            return minIndex;
        }
        //Method to find tallest
        public static int FindTallest(double[] heights)
        {
            int maxIndex = 0;
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > heights[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
    }
}
