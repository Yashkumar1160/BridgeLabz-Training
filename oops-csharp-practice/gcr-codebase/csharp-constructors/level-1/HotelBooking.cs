using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.level_1
{
    internal class HotelBooking
    {
        //attributes to store data

        string guestName;

        string roomType;

        int nights;

        //create default constructor
        public HotelBooking()
        {
            guestName = "Guest";

            roomType = "Single";

            nights = 1;
        }

        //create parameterized constructor
        public HotelBooking(string guestName, string roomType, int nights)
        {
            this.guestName = guestName;

            this.roomType = roomType;

            this.nights = nights;
        }

        //create copy constructor
        public HotelBooking(HotelBooking hotelBooking)
        {
            this.guestName = hotelBooking.guestName;

            this.roomType = hotelBooking.roomType;

            this.nights = hotelBooking.nights;
        }

        public static void Main(string[] args)
        {
            //create object using default constructor
            HotelBooking hotelBooking1 = new HotelBooking();

            //take guest name input
            Console.Write("ENTER NAME: ");
            string guestName = Console.ReadLine();

            //take room type input
            Console.Write("ENTER ROOM TYPE: ");
            string roomType = Console.ReadLine();

            //take room type input
            Console.Write("ENTER NIGHTS: ");
            int nights = Convert.ToInt32(Console.ReadLine());

            //create object using parameterized constructor
            HotelBooking hotelBooking2 = new HotelBooking(guestName, roomType, nights);

            //create objecy using copy constructor
            HotelBooking hotelBooking3 = new HotelBooking(hotelBooking2);

            //call DisplayDetails Method
            Console.WriteLine("\nUSING DEFALUT CONSTRUCTOR:");
            hotelBooking1.DisplayDetails();

            Console.WriteLine("\nUSING PARAMETERIZED CONSTRUCTOR:");
            hotelBooking2.DisplayDetails();

            Console.WriteLine("\nUSING COPY CONSTRUCTOR:");
            hotelBooking3.DisplayDetails();

        }

        //---------------DISPLAY DETAILS-----------------
        //method to DISPLAY DETAILS of HotelBooking
        public void DisplayDetails()
        {
            //display details of HotelBooking
            Console.WriteLine("GUEST NAME: " + guestName);

            Console.WriteLine("ROOM TYPE: " + roomType);

            Console.WriteLine("NIGHTS: " + nights);


        }

    }
}
