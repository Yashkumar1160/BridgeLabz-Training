using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bird_sanctuary_system
{
    internal class BirdSanctuary
    {
        //store name of bird sanctuary
        static string name = "BIRD SANCTUARY";

        //array to store birds
        Bird[] birds = new Bird[100];

        //varaible to store  total bird count
        int totalBirds = 0;

        //method to add a bird
        public void AddBird(Bird bird)
        {
            birds[totalBirds]=bird;

            totalBirds++;
        }

        //method to find a bird
        public Bird FindBird(string species)
        {
            for(int i = 0; i < totalBirds; i++)
            {
                //check if bird species is same
                if (birds[i].GetSpecies().ToLower()==species.ToLower())
                {
                    return birds[i];
                }
            }

            return null;
        }

        //method to view all birds 
        public void ViewAllBirds()
        {
            Console.WriteLine("ALL BIRDS DETAILS: ");

            for(int i=0;i< totalBirds;i++)
            {
                //flags to check if bird can fly or not
                bool canFly=false;

                //flags to check if bird can swim or not
                bool canSwim =false;

                birds[i].DisplayDetails();
                    
                //check if bird object implements IFlyable and casts it into IFlyable 
                if (birds[i] is IFlyable fly)
                {
                    canFly = fly.CanFly();
                }
                
                //check if bird object implements ISwimmable and casts it into ISwimmable
                if (birds[i] is ISwimmable swim)
                {
                    canSwim = swim.CanSwim();
                }

                //check both flags
                if (canSwim && canFly)
                {
                    Console.WriteLine("CAN FLY AND SWIM");
                }
                else if (canFly)
                {
                    Console.WriteLine("CAN FLY");
                }
                else if(canSwim)
                {
                    Console.WriteLine("CAN SWIM");
                }
                else
                {
                    Console.WriteLine("CANNOT FLY OR SWIM");
                }
            }
        }
    }
}
