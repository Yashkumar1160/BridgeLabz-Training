using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techville.modules;

namespace techville.datastructures
{
    //M-11 Service Queue Management
    public class ArrayQueue
    {

        //citizen queue
        private Citizen[] queue = new Citizen[10];
        //front and rear
        private int front = -1;
        private int rear = -1;

        //Method for Enqueue
        public void Enqueue(Citizen citizen)
        {
            if (rear == queue.Length - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }

            if (front == -1)
                front = 0;

            queue[++rear] = citizen;
            Console.WriteLine(citizen.Name + " added to Array Queue");
        }

        //Method for Dequeue
        public void Dequeue()
        {
            if (front == -1 || front > rear)
            {
                Console.WriteLine("Queue Underflow");
                return;
            }

            Console.WriteLine("Removed: " + queue[front].Name);
            front++;
        }

        //Method to Display Queue
        public void Display()
        {
            if (front == -1)
            {
                Console.WriteLine("Queue Empty");
                return;
            }

            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine(queue[i].Name);
            }
        }
    }
}