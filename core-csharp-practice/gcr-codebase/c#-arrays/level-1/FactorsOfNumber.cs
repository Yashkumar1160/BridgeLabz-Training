using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_1
{
    internal class FactorsOfNumber
    {
        public static void Main(string[] args)
        {
            //take number input
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            //initialize maxFactor variable to 1
            int maxFactor = 10;
            //initialize integer array factors with size maxFactor
            int[] factors = new int[maxFactor];
            //initialize index variable to 0
            int index = 0;

            //loop to find factors
            for (int i = 1; i <= number; i++)
            {
                //check if i is a factor
                if (number % i == 0)
                {
                    if (index == maxFactor)
                    {   //if array is full then increase its size
                        maxFactor = maxFactor * 2;

                        //create temporary array
                        int[] temp = new int[maxFactor];

                        //copy all the elements to new array
                        for (int j = 0; j < factors.Length; j++)
                        {
                            temp[j] = factors[j];
                        }
                        //assign new array
                        factors = temp;
                    }
                    factors[index] = i;
                    index++;
                }
            }
            Console.WriteLine("Factors of " + number + " are: ");
            for (int i = 0; i < index; i++)
            {   //display factors of the number
                Console.Write(factors[i] + " ");
            }

        }


    }
}
