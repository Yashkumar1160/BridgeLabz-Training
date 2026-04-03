using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.level_1
{
    internal class CarRental
    {

        //attributes to store data
        string customerName;

        string carModel;

        int rentalDays;

        double totalCost;

        //create default constructor
        public CarRental()
        {
            customerName = "Guest";

            carModel = "Sedan";

            rentalDays = 2;
        }

        //create parameterized constructor

        public CarRental(string customerName, string carModel, int rentalDays)
        {
            this.customerName = customerName;

            this.carModel = carModel;

            this.rentalDays = rentalDays;
        }

        //create copy constructor

        public CarRental(CarRental carRental)
        {
            this.customerName = carRental.customerName;

            this.carModel = carRental.carModel;

            this.rentalDays = carRental.rentalDays;
        }
        public static void Main(string[] args)
        {
            //create object of class using default constructor
            CarRental carRental1 = new CarRental();

            //take customer name
            Console.Write("ENTER CUSTOMER NAME:");
            string customerName = Console.ReadLine();

            //take car model
            Console.Write("ENTER CAR MODEL:");
            string carModel = Console.ReadLine();

            //take rental days
            Console.Write("ENTER RENTAL DAYS:");
            int rentalDays = Convert.ToInt32(Console.ReadLine());

            //create object of class using parameterized constructor
            CarRental carRental2 = new CarRental(customerName, carModel, rentalDays);

            //create object of class using copy constructor
            CarRental carRental3 = new CarRental(carRental2);


            //call the CalculateCost method
            Console.WriteLine("\nDEFAULT CONSTRUCTOR:");
            carRental1.DisplayDetails();

            //call the CalculateCost method
            Console.WriteLine("\nPARAMETERIZED CONSTRUCTOR:");

            carRental2.DisplayDetails();

            //call the CalculateCost method
            Console.WriteLine("\nCOPY CONSTRUCTOR:");
            carRental3.DisplayDetails();

        }

        //--------------DISPLAY DETAILS--------------
        //method to display details 
        public void DisplayDetails()
        {
            Console.WriteLine("\nCustomer Name : " + customerName);
            
            Console.WriteLine("Car Model     : " + carModel);
            
            Console.WriteLine("Rental Days   : " + rentalDays);
            
            Console.WriteLine("Total Cost    : " + FindTotalCost());
            
            Console.WriteLine("--------------------------------");
        }

        //--------------FIND TOTAL COST--------------
        //method to find total cost
        public int FindTotalCost()
        {
            //calculate total cost
            int totalCost = rentalDays * 1000;

            return totalCost;
        }
    }
}
