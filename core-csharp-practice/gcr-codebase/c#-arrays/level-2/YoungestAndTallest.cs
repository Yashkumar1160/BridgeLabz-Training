using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_2
{
    internal class YoungestAndTallest
    {
        public static void Main(string[] args)
        {
            //define integer array age to store ages
            int[] age = new int[3];
            //define double array height to store heights
            double[] height = new double[3];

            //initialize string array names to store names 
            string[] names = { "Amar", "Akbar", "Anthony" };

            //take user inputs
            for (int i = 0; i < 3; i++)
            {   //take age inputs of Amar, Akbar and Anthony
                Console.WriteLine("Enter age of " + names[i]);
                age[i] = Convert.ToInt32(Console.ReadLine());
                //take height inputs of Amar, Akbar and Anthony
                Console.WriteLine("Enter height of " + names[i]);
                height[i] = Convert.ToDouble(Console.ReadLine());
            }
            //store youngest and tallest index
            int youngestIndex = 0;
            int tallestIndex = 0;
            //find youngest and tallest
            for (int i = 1; i < 3; i++)
            {
                if (age[i] < age[youngestIndex])
                {
                    youngestIndex = i;
                }
                if (height[i] > height[tallestIndex])
                {
                    tallestIndex = i;
                }
            }
            Console.WriteLine("Youngest is : " + names[youngestIndex]);
            Console.WriteLine("Tallest is : " + names[tallestIndex]);
        }
    }
}
