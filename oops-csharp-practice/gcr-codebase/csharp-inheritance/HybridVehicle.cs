using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    //base class HybridVehicle
    internal class HybridVehicle
    {
        //protected variables
        protected int maxSpeed;

        protected string model;

        //parameterized constructor
        public HybridVehicle(int maxSpeed, string model)
        {
            this.maxSpeed = maxSpeed;
            this.model = model;
        }

        //method to display vehicle details
        public virtual void DisplayDetails()
        {
            Console.WriteLine("MAX SPEED: " + maxSpeed);

            Console.WriteLine("MODEL: " + model);
        }
    }

    //interface Refuelable
    interface Refuelable
    {
        //Refuel method
        void Refuel();
    }

    //derived class ElectricVehicle 
    class ElectricVehicle : HybridVehicle
    {
        //parameterized constructor
        public ElectricVehicle(int maxSpeed, string model) : base(maxSpeed, model) { }

        //method to charge vehicle
        public void Charge()
        {
            Console.WriteLine("ELECTRIC VEHICLE IS CHARGING");
        }
        
        //override DisplayDetails method
        public override void DisplayDetails()
        {
            Console.WriteLine("\nVEHICLE TYPE: ELECTRIC");

            //call base class DisplayDetails method
            base.DisplayDetails();
        }
    }

    //derived class PetrolVehicle implementing Refuelable interface
    class PetrolVehicle : HybridVehicle, Refuelable
    {
        //parameterized constructor
        public PetrolVehicle(int maxSpeed, string model) : base(maxSpeed, model) { }

        //implementation of Refuel method
        public void Refuel()
        {
            Console.WriteLine("PETROL VEHICLE IS REFUELING");
        }

        //override DisplayDetails method
        public override void DisplayDetails()
        {
            Console.WriteLine("\nVEHICLE TYPE : PETROL");

            //call base class DisplayDetails method
            base.DisplayDetails();
        }
    }

    //class containing main method
    class Program
    {
        public static void Main(string[] args)
        {
            //call TakeInputs method
            TakeInputs();
        }

        //method to take user inputs
        public static void TakeInputs()
        {
            //take electric vehicle model input
            Console.Write("ENTER ELECTRIC VEHICLE MODEL: ");
            string electricModel = Console.ReadLine();

            //take electric vehicle speed input
            Console.Write("ENTER ELECTRIC VEHICLE MAX SPEED: ");
            int electricSpeed = Convert.ToInt32(Console.ReadLine());

            //create object of ElectricVehicle class
            ElectricVehicle electricVehicle = new ElectricVehicle(electricSpeed, electricModel);

            //take petrol vehicle model input
            Console.Write("\nENTER PETROL VEHICLE MODEL: ");
            string petrolModel = Console.ReadLine();

            //take petrol vehicle speed input
            Console.Write("ENTER PETROL VEHICLE MAX SPEED: ");
            int petrolSpeed = Convert.ToInt32(Console.ReadLine());

            //create object of PetrolVehicle class
            HybridVehicle petrolVehicle = new PetrolVehicle(petrolSpeed, petrolModel);

            //call DisplayDetails method 
            electricVehicle.DisplayDetails();

            //call Charge method
            electricVehicle.Charge();

            //call DisplayDetails method
            petrolVehicle.DisplayDetails();

            // Interface reference
            Refuelable fuelVehicle = (Refuelable)petrolVehicle;

            //call Refuel method
            fuelVehicle.Refuel();
        }
    }
}
