using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    //base class Vehicle
    internal class Vehicle
    {
        //protected variables
        protected int maxSpeed;

        protected string fuelType;

        //parameterized constructor
        public Vehicle(int speed, string fuelType)
        {
            this.maxSpeed = speed;
            this.fuelType = fuelType;
        }

        //method to display vehicle details
        public virtual void DisplayInfo()
        {
            Console.WriteLine("MAXSPEED: " + maxSpeed);
            Console.WriteLine("FUELTYPE: " + fuelType);
        }
    }

    //derived class Car
    class Car : Vehicle
    {
        //private variable
        int seatCapacity;

        //parameterized constructor
        public Car(int speed, string fuelType, int seatCapacity) : base(speed, fuelType)
        {
            this.seatCapacity = seatCapacity;
        }

        //override DisplayInfo method
        public override void DisplayInfo()
        {
            //call base class DisplayInfo method
            base.DisplayInfo();

            Console.WriteLine("SEATS: " + seatCapacity);
        }
    }

    //derived class Truck
    class Truck : Vehicle
    {
        //private variable
        int payloadCapacity;

        //parameterized constructor
        public Truck(int speed, string fuelType, int payloadCapacity) : base(speed, fuelType)
        {
            this.payloadCapacity = payloadCapacity;
        }

        //override DisplayInfo Method
        public override void DisplayInfo()
        {
            base.DisplayInfo();

            Console.WriteLine("PAYLOAD CAPACITY: " + payloadCapacity);
        }
    }

    //derived class Motorcycle
    class Motorcycle : Vehicle
    {
        //private variable
        bool hasSideCar;

        //parameterized constructor
        public Motorcycle(int speed, string fuelType, bool hasSideCar) : base(speed, fuelType)
        {
            this.hasSideCar = hasSideCar;
        }

        //override DisplayInfo method
        public override void DisplayInfo()
        {
            //call base class DisplayInfo method
            base.DisplayInfo();

            Console.WriteLine("SIDECAR: " + hasSideCar);
        }
    }

    //class containing Main method
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
            //take car speed input
            Console.Write("ENTER CAR SPEED: ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            //take car fuel type input
            Console.Write("ENTER FUEL TYPE: ");
            string carFuelType = Console.ReadLine();

            //take car seat capacity input
            Console.Write("ENTER SEATCAPACITY: ");
            int seatCapacity = Convert.ToInt32(Console.ReadLine());

            //create object of class Car
            Vehicle car = new Car(carSpeed, carFuelType, seatCapacity);

            //take truck speed input
            Console.Write("\nENTER TRUCK SPEED: ");
            int truckSpeed = Convert.ToInt32(Console.ReadLine());

            //take truck fuel type input
            Console.Write("ENTER FUELTYPE: ");
            string truckFuelType = Console.ReadLine();

            //take payload input
            Console.Write("ENTER PAYLOAD CAPACITY: ");
            int payload = Convert.ToInt32(Console.ReadLine());

            //create object of Truck class
            Vehicle truck = new Truck(truckSpeed, truckFuelType, payload);

            //take motorcycle speed input
            Console.Write("\nENTER MOTORCYCLE SPEED: ");
            int motorcycleSpeed = Convert.ToInt32(Console.ReadLine());

            //take motorcycle fuel type input
            Console.Write("ENTER FUELTYPE: ");
            string motorcycleFuelType = Console.ReadLine();

            //take sidecar input
            Console.Write("HAS SIDE CAR: ");
            bool sidecar = Convert.ToBoolean(Console.ReadLine());

            //create object of motorcycle class
            Vehicle motorcycle = new Motorcycle(motorcycleSpeed, motorcycleFuelType, sidecar);


            //call DisplayInfo method using different objects
            Console.WriteLine("\nCAR DETAILS: ");
            car.DisplayInfo();

            Console.WriteLine("\nTRUCK DETAILS: ");
            truck.DisplayInfo();

            Console.WriteLine("\nMOTORCYCLE DETAILS: ");
            motorcycle.DisplayInfo();
        }
    }
}
