using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.traffic_manager
{
    internal class RoundaboutUtilityImpl:IRoundabout
    {
        //last node of circular linked list
        private VehicleNode last = null;


        //method to check if roundabout is empty
        public bool IsEmpty()
        {
            return last == null;
        }


        //method to add vehicle into roundabout
        public void AddVehicle(int vehicleNumber)
        {
            //create new vehicle node
            VehicleNode node = new VehicleNode(vehicleNumber);

            //if roundabout is empty
            if (last == null)
            {
                last = node;
                last.next = last; 
            }
            else
            {
                //insert node after last
                node.next = last.next;
                last.next = node;
                last = node;
            }

            Console.WriteLine("\nVEHICLE " + vehicleNumber + " ENTERED ROUNDABOUT");
        }



        //method to remove vehicle from roundabout
        public int RemoveVehicle()
        {
            //if roundabout is empty
            if (last == null)
            {
                Console.WriteLine("\nNO VEHICLE IN ROUNDABOUT");
                return -1;
            }

            //store first vehicle
            VehicleNode first = last.next;
            int removedVehicle = first.vehicleNumber;

            //if only one vehicle present
            if (last == first)
            {
                last = null;
            }
            else
            {
                last.next = first.next;
            }

            Console.WriteLine("\nVEHICLE " + removedVehicle + " EXITED");
            return removedVehicle;
        }



        //method to display roundabout state
        public void DisplayRoundabout()
        {
            //if roundabout is empty
            if (last == null)
            {
                Console.WriteLine("\nROUNDABOUT IS EMPTY");
                return;
            }

            Console.Write("\nROUNDABOUT: ");

            //start from first vehicle
            VehicleNode temp = last.next;

            //print first vehicle separately
            Console.Write(temp.vehicleNumber + " ");
            temp = temp.next;

            //loop until we reach first vehicle again
            while (temp != last.next)
            {
                Console.Write(temp.vehicleNumber + " ");
                temp = temp.next;
            }

            Console.WriteLine();
        }
    }
}
