using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_stacks_queues_hashmaps
{
    internal class CircularTour
    {
       public static void Main(string[] args)
       {
            //take size of array
            Console.WriteLine("ENTER ARRAY SIZE: ");
            int size = Convert.ToInt32(Console.ReadLine());

            //petrol at each pump
            int[] petrol = new int[size];

            int[] distance = new int[size];

            //loop to take petrol inputs
            for (int i = 0; i < size; i++)
            {
                Console.Write("ENTER PETROL VALUE: ");
                petrol[i] = Convert.ToInt32(Console.ReadLine());
            }

            //loop to take distance inputs
            for (int i = 0; i < size; i++)
            {
                Console.Write("ENTER DISTANCE: ");
                distance[i] = Convert.ToInt32(Console.ReadLine());
            }
            //variable to store starting pump
            int start = FindStartingPump(petrol, distance);

            //check if start is -1
            if (start == -1)
            {
                Console.WriteLine("NO POSSIBLE TOUR");
            }
            else
            {
                Console.WriteLine("START AT PUMP INDEX: " + start);
            }

        }

        //method to find starting pump
        public static int FindStartingPump(int[] petrol, int[] distance)
        {
            //store length of petrol array
            int n = petrol.Length;

            int start = 0;
            int surplus = 0;
            int deficit = 0;

            //traverse all petrol pumps
            for (int i = 0; i < n; i++)
            {
                //add petrol and subtract distance
                surplus = surplus + petrol[i] - distance[i];

                //if petrol becomes negative
                if (surplus < 0)
                {
                    //cannot start from previous start
                    start = i + 1;

                    //add shortage to deficit
                    deficit = deficit + surplus;

                    //reset surplus
                    surplus = 0;
                }
            }

            //check if total petrol is enough
            if (surplus + deficit >= 0)
            {
                return start;

            }
            else
            {
                return -1;
            }
        }
    }
}

