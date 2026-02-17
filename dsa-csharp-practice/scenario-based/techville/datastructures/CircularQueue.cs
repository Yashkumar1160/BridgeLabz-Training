using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techville.modules;

namespace techville.datastructures
{
    //M-11 Circular Array Queue
    public class CircularArrayQueue
    {
        private Citizen[] queue = new Citizen[5];
        private int front = -1;
        private int rear = -1;

        public void Enqueue(Citizen citizen)
        {
            if ((rear + 1) % queue.Length == front)
            {
                Console.WriteLine("Circular Queue Full");
                return;
            }

            if (front == -1)
                front = 0;

            rear = (rear + 1) % queue.Length;
            queue[rear] = citizen;
        }

        public void Display()
        {
            if (front == -1)
            {
                Console.WriteLine("Queue Empty");
                return;
            }

            int i = front;

            while (true)
            {
                Console.WriteLine(queue[i].Name);
                if (i == rear) break;
                i = (i + 1) % queue.Length;
            }
        }
    }
}