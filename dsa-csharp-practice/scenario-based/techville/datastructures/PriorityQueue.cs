using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techville.modules;

namespace techville.datastructures
{
    //M-11 Priority Queue for Emergency Services
    public class PriorityQueue
    {
        //citizen priority queue
        private (Citizen citizen, int priority)[] queue =new (Citizen, int)[10];
        private int count = 0;

        //Method to Insert based on priority 
        public void Enqueue(Citizen citizen, int priority)
        {
            if (count == queue.Length)
            {
                Console.WriteLine("Priority Queue Full");
                return;
            }

            queue[count++] = (citizen, priority);

             // Sort based on priority (Item2)
            Array.Sort(queue, 0, count,Comparer<(Citizen, int)>.Create((a, b) => b.Item2.CompareTo(a.Item2)));

            Console.WriteLine(citizen.Name + " added with priority " + priority);
        }

        public void Display()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(queue[i].citizen.Name +
                                  " Priority: " + queue[i].priority);
            }
        }
    }
}