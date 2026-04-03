using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.delivery_management
{
    internal class ParcelTrackerMenu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("--------DELIVERY CHAIN MANAGEMENT SYSTEM--------");

            //add a parcel first
            Console.WriteLine("Add Parcel Details: ");

            //take order id
            Console.Write("\nENTER ORDER ID: ");
            int orderId = Convert.ToInt32(Console.ReadLine());

            //take customer name
            Console.Write("ENTER CUSTOMER NAME: ");
            string name = Console.ReadLine();

            //create object of Parcel class
            Parcel parcel = new Parcel(orderId, name);

            //create object of ParcelTrackerUtilityImpl class
            ParcelTrackerUtilityImpl utility=new ParcelTrackerUtilityImpl();


            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\n1. ADD DELIVERY STAGE");
                Console.WriteLine("2. ADD CHECKPOINT");
                Console.WriteLine("3. TRACK PARCEL");
                Console.WriteLine("4. CHECK PARCEL STATUS");
                Console.WriteLine("5. DETECT LOST PARCEL");
                Console.WriteLine("6. EXIT PROGRAM");
                Console.Write("ENTER YOUR CHOICE: ");


                //take user's choice
                int choice=Convert.ToInt32(Console.ReadLine());


                //handle user's choice
                switch(choice)
                {
                    //add delivery stage
                    case 1:
                        utility.AddDeliveryStage(parcel);
                        break;


                    //add checkpoint stage
                    case 2:
                        utility.AddCheckPoint();
                        break;


                    //track pracel
                    case 3:
                        utility.TrackParcel();
                        break;


                    //check pracel status
                    case 4:
                        utility.CheckParcelStatus();
                        break;


                    //detect lost parcel
                    case 5:
                        utility.DetectLostParcel();
                        break;
                        

                    //exit
                    case 6:
                        Console.WriteLine("Exit Successful");
                        return;


                    //invalid choice
                    default:
                        Console.WriteLine("INVALID CHOICE");
                        break;
                        
                }
            }
        }
    }
}
