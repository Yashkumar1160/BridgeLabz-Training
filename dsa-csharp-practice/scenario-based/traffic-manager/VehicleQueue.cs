using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.traffic_manager
{
    internal class VehicleQueue
    {
        //array to store vehicles
        private int[] queue;

        //front and rear pointers
        private int front = 0;
        private int rear = -1;

        //capacity of queue
        private int capacity;

        //current size
        private int size = 0;


        //constructor
        public VehicleQueue(int capacity)
        {
            this.capacity = capacity;
            queue = new int[capacity];
        }


        //method to check if queue is full
        public bool IsFull()
        {
            return rear == capacity - 1;
        }


        //method to check if queue is empty
        public bool IsEmpty()
        {
            return front > rear;
        }



        //method to add vehicle into queue
        public void Enqueue(int vehicleNumber)
        {
            //if queue is full
            if (IsFull())
            {
                Console.WriteLine("\nQUEUE OVERFLOW : WAITING AREA IS FULL");
                return;
            }

            //increment rear and add vehicle
            queue[++rear] = vehicleNumber;
            Console.WriteLine("\nVEHICLE " + vehicleNumber + " ADDED TO WAITING QUEUE");
        }



        //method to remove vehicle from queue
        public int Dequeue()
        {
            //if queue is empty
            if (IsEmpty())
            {
                Console.WriteLine("\nQUEUE UNDERFLOW : NO VEHICLE WAITING");
                return -1;
            }

            //remove vehicle from front
            return queue[front++];
        }



        //method to display queue state
        public void DisplayQueue()
        {
            //if queue is empty
            if (IsEmpty())
            {
                Console.WriteLine("\nWAITING QUEUE IS EMPTY");
                return;
            }

            Console.Write("\nWAITING QUEUE: ");
            for (int i = front; i <= rear; i++)
            {
                Console.Write(queue[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
