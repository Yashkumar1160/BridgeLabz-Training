using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.review.bus_reservation
{
    internal class bus_reservation
    {
        //total seats 
        static int totalSeats = 30;

        //array to store if seat is booked or not
        static bool[] seats = new bool[totalSeats];

        //array to store customer names
        static string[] customerNames = new string[totalSeats];

        //array to store customer ages
        static int[] customerAges = new int[totalSeats];

        //array to store customer genders
        static string[] customerGenders = new string[totalSeats];

        //array to store customer seat numbers
        static int[] seatNumbers = new int[totalSeats];

        //total reservations
        static int totalReservation = 0;

        //price of seats
        static int price = 500;

        public static void Main(string[] args)
        {
            HandleChoices();
        }

        public static void HandleChoices()
        {
            Console.WriteLine("WELCOME TO BUS SERVICE");

            Console.WriteLine("AGRA --------------> DELHI");

            //infinite loop until user exits
            while (true)
            {
                //display choices
                Console.WriteLine("\n1. BOOK TICKETS");

                Console.WriteLine("2. AVAILABLE TICKETS");

                Console.WriteLine("3. CUSTOMER DETAILS");

                Console.WriteLine("4. EXIT");

                Console.Write("ENTER YOUR CHOICE: ");

                //take users choice
                int choice = Convert.ToInt32(Console.ReadLine());


                //handle users choice
                switch (choice)
                {
                    case 1:
                        Console.Write("\nENTER NUMBER OF SEATS: ");

                        int numberOfSeats = Convert.ToInt32(Console.ReadLine());

                        if (numberOfSeats > totalSeats)
                        {
                            Console.WriteLine("ENTER VALID SEATNUMBER");
                            continue;
                        }

                        BookTickets(numberOfSeats);

                        totalSeats = totalSeats - numberOfSeats;

                        break;

                    case 2:

                        Console.WriteLine("\nSEATS AVAILABLE: " + totalSeats);
                        break;

                    case 3:
                        DisplayDetails();
                        break;

                    case 4:
                        Console.WriteLine("\nTHANKYOU");
                        return;

                    default:
                        Console.WriteLine("\nINVALID CHOICE");
                        break;

                }
            }
        }

        public static void BookTickets(int numberOfSeats)
        {
            for (int i = 0; i < numberOfSeats; i++)
            {
                //take person name and store it in the array
                Console.Write($"\nENTER NAME OF PERSON {i + 1}: ");
                string name = Console.ReadLine();
                customerNames[totalReservation] = name;

                //take person age 
                Console.Write($"ENTER AGE OF PERSON {i + 1}: ");
                int age = Convert.ToInt32(Console.ReadLine());

                //check if age is valid or not 
                while (CheckAge(age) == false)
                {
                    Console.WriteLine("ENTER VALID AGE: ");
                    age = Convert.ToInt32(Console.ReadLine());
                }
                //store age in ages array
                customerAges[totalReservation] = age;

                //take person gender
                Console.Write($"ENTER GENDER OF PERSON {i + 1}: ");
                string gender = Console.ReadLine();

                //check for valid gender
                while (CheckGender(gender) == false)
                {
                    Console.WriteLine("ENTER VALID GENDER: ");
                    gender = Console.ReadLine();
                }
                //store  gender in array
                customerGenders[totalReservation] = gender;

                //take the required seat number 
                Console.Write("ENTER SEAT NUMBER: ");
                int seatNumber = Convert.ToInt32(Console.ReadLine());

                //check if seat is available or not 
                while (seats[seatNumber - 1] == true)
                {
                    Console.WriteLine("\nSEAT OCCUPIED");

                    Console.Write("\nENTER ANOTHER SEAT NUMBER: ");

                    seatNumber = Convert.ToInt32(Console.ReadLine());
                }

                //update seat availability
                seats[seatNumber - 1] = true;

                seatNumbers[totalReservation] = seatNumber;

                //update total reservations
                totalReservation++;

            }

            Console.WriteLine("TOTAL FARE: " + price * numberOfSeats);

            Console.WriteLine("\nBOOKING CONFIRMED");

        }

        //method to check age
        public static bool CheckAge(int age)
        {
            return age > 0 && age < 110;
        }


        //method to check gender
        public static bool CheckGender(string gender)
        {
            if (gender.ToLower() == "male" || gender.ToLower() == "female")
            {
                return true;
            }

            return false;
        }

        //method to display customer details
        public static void DisplayDetails()
        {
            Console.WriteLine("\nCUSTOMER DETAILS: ");

            for (int i = 0; i < totalReservation; i++)
            {
                Console.WriteLine("\nNAME: " + customerNames[i]);

                Console.WriteLine("AGE: " + customerAges[i]);

                Console.WriteLine("GENDER: " + customerGenders[i]);

                Console.WriteLine("SEAT NUMBER: " + seatNumbers[i]);
            }
        }

    }
}
