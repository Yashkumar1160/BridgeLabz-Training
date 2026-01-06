using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bird_sanctuary_system
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {
            Console.WriteLine("----WELCOME TO BIRD SANCTUARY----");

            //create object of class BirdSanctuary
            BirdSanctuary birdSanctuary = new BirdSanctuary();

            //infinite loop until user exits
            while (true)
            {
                //display choices 
                Console.WriteLine("\n1. ADD BIRD");
                Console.WriteLine("2. FIND BIRD");
                Console.WriteLine("3. DISPLAY ALL BIRDS");
                Console.WriteLine("4. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        AddBirdChoice(birdSanctuary);
                        break;

                    case 2:
                        Console.Write("\nENTER BIRD SPECIES: ");
                        string species = Console.ReadLine();

                        Bird bird = birdSanctuary.FindBird(species);

                        if (bird == null)
                        {
                            Console.WriteLine("BIRD NOT FOUND");
                        }
                        else
                        {
                            Console.WriteLine("BIRD FOUND SUCCESSFULLY");
                            bird.DisplayDetails();
                        }
                        break;

                    case 3:
                        birdSanctuary.ViewAllBirds();
                        break;

                    case 4:
                        Console.WriteLine("\nEXIT SUCCESSFUL. THANKYOU");
                        return;

                    //if user enters invalid input
                    default:
                        Console.WriteLine("INVALID INPUT");
                        break;
                }

            }
        }

        public static void AddBirdChoice(BirdSanctuary birdSanctuary)
        {
            //infinite loop until user exits
            while (true)
            {
                //display choices
                Console.WriteLine("\n1. ADD EAGLE");
                Console.WriteLine("2. ADD SPARROW");
                Console.WriteLine("3. ADD PENGUIN");
                Console.WriteLine("4. ADD DUCK");
                Console.WriteLine("5. ADD SEAGULL");
                Console.WriteLine("6. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    //if user wants to add an eagle
                    case 1:
                        //read bird species
                        Console.Write("\nENTER EAGLE SPECIES: ");
                        string eagleSpecies = Console.ReadLine();

                        //read bird's color
                        Console.Write("ENTER BIRD COLOR: ");
                        string eagleColor = Console.ReadLine();

                        //create object and add bird
                        birdSanctuary.AddBird(new EagleImpl(eagleSpecies, eagleColor));

                        Console.WriteLine("BIRD ADDED");

                        break;

                    //if user wants to add a sparrow
                    case 2:
                        //read bird species
                        Console.Write("\nENTER SPARROW SPECIES: ");
                        string sparrowSpecies = Console.ReadLine();

                        //read bird's color
                        Console.Write("ENTER BIRD COLOR: ");
                        string sparrowColor = Console.ReadLine();

                        //create object and add bird
                        birdSanctuary.AddBird(new SparrowImpl(sparrowSpecies, sparrowColor));

                        Console.WriteLine("BIRD ADDED");

                        break;

                    //if user wants to add a penguin
                    case 3:
                        //read bird species
                        Console.Write("\nENTER PENGUIN SPECIES: ");
                        string penguinSpecies = Console.ReadLine();

                        //read bird's color
                        Console.Write("ENTER BIRD COLOR: ");
                        string penguinColor = Console.ReadLine();

                        //create object and add bird
                        birdSanctuary.AddBird(new PenguinImpl(penguinSpecies, penguinColor));

                        Console.WriteLine("BIRD ADDED");

                        break;

                    //if user wants to add a duck
                    case 4:
                        //read bird species
                        Console.Write("\nENTER DUCK SPECIES: ");
                        string duckSpecies = Console.ReadLine();

                        //read bird's color
                        Console.Write("ENTER BIRD COLOR: ");
                        string duckColor = Console.ReadLine();

                        //create object and add bird
                        birdSanctuary.AddBird(new DuckImpl(duckSpecies, duckColor));

                        Console.WriteLine("BIRD ADDED");

                        break;

                    //if user wants to add a seagull
                    case 5:
                        //read bird species
                        Console.Write("\nENTER SEAGULL SPECIES: ");
                        string seagullSpecies = Console.ReadLine();

                        //read bird's color
                        Console.Write("ENTER BIRD COLOR: ");
                        string seagullColor = Console.ReadLine();

                        //create object and add bird
                        birdSanctuary.AddBird(new SeagullImpl(seagullSpecies, seagullColor));

                        Console.WriteLine("BIRD ADDED");

                        break;

                    //if user wants to exit
                    case 6:
                        Console.WriteLine("\nEXIT SUCCESSFUL");
                        return;

                    //if user enters invalid input
                    default:
                        Console.WriteLine("INVALID INPUT");
                        break;

                }
            }
        }
    }
}
