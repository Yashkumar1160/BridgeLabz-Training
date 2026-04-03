using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.delivery_management
{
    internal class ParcelTracker
    {
        //head node
        StageNode head;
       


        //method to add a delivery stage
        public void AddDeliveryStage(Parcel parcel,string deliveryStage)
        {
            //create a node 
            StageNode node = new StageNode(parcel, deliveryStage);

            //if head node is null 
            if(head ==null)
            {
                //new node becomes head
                head = node;
                Console.WriteLine("\nStage Added Successfully");

                return;
            }

            //store head node in temp variable
            StageNode temp= head;

            //traverse list
            while(temp.Next!=null)
            {
                temp=temp.Next;
            }

            //add new node at last
            temp.Next=node;
            node.Next = null;

            //if delivery stage is added then parcel has been delivered 
            if (deliveryStage.ToLower() == "delivered")
            {
                //update delivery status of parcel
                parcel.IsDelivered= true;
            }

            Console.WriteLine("\nStage Added Successfully");
        }



        //method to track parcel
        public void TrackParcel()
        {
            //store head in temp variable 
            StageNode temp= head;

            //if temp is null
            if (temp == null)
            {
                Console.WriteLine("\nNo Parcel Added Yet");
                return;
            }

            //traverse list
            while(temp!=null)
            {
                Console.WriteLine(temp.stage);
                temp= temp.Next;
            }
        }



        //method to detect lost parcel
        public void FindLostParcel()
        {
            if (head == null)
            {
                Console.WriteLine("\nNo Parcel Added Yet");
                return;
            }

            //store head in current variable
            StageNode current=head;
            //initialize previous node with null
            StageNode prev=null;

            //traverse list
            while(current!=null)
            {
                //update prev and current
                prev = current;
                current = current.Next; 
            }

            //if the previous stage is not "delivered" 
            if (prev.stage.ToLower() != "delivered")
            {
                //parcel is lost 
                Console.WriteLine("\nParcel Lost: ");
                Console.WriteLine(prev.parcel);
            }
            //parcel is delivered
            else
            {
                Console.WriteLine("\nParcel delivered successfully");
            }
        }



        //method to add custom checkpoint
        public void AddCheckpoint(string afterStage, string checkpoint)
        {
            if (head == null)
            {
                Console.WriteLine("\nNo Stage Exists Yet");
                return;
            }

            //store head in temp node
            StageNode temp= head;

            //search for after stage
            while (temp!=null && temp.stage.ToLower() != afterStage)
            {
                temp= temp.Next;
            }

            //if after staage is not found
            if (temp == null)
            {
                Console.WriteLine("\nStage Not Found");
                return;
            }

            //create new node for checkpoint
            StageNode checkpointStage=new StageNode(temp.parcel,checkpoint);

            //add checkpoint node
            checkpointStage.Next=temp.Next;
            temp.Next = checkpointStage;

            Console.WriteLine("\nCheckpoint Added Successfully");
        }



        //method to check parcel status
        public void CheckParcelStatus()
        {
            //if no parcel stage is added yet
            if (head == null)
            {
                Console.WriteLine("\nNo Parcel Added Yet");
                return;
            }

            //store head in temp variable
            StageNode temp=head;

            //traverse list
            while (temp.Next != null)
            {
                temp= temp.Next;
            }

            Console.WriteLine(temp.stage);
        }
    }
}
