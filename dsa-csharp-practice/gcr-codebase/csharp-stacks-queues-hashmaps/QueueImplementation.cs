using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_stacks_queues_hashmaps
{
    internal class QueueImplementation
    {


        //main method
        public static void Main()
        {
            //create object of class QueueImplementation
            QueueImplementation queue = new QueueImplementation();

            //add elements in queue
            queue.Enqueue(4);

            queue.Enqueue(8);

            queue.Enqueue(10);

            //see element at front
            queue.Peek();

            //remove elements from queue
            queue.Dequeue();

            queue.Dequeue();

            //see element at front
            queue.Peek();
        }


        //create two stacks
        Stack<int> stack1 = new Stack<int>();

        Stack<int> stack2 = new Stack<int>();

        //method for enque operation
        public void Enqueue(int element)
        {
            //push into stack1
            stack1.Push(element);

            Console.WriteLine($"\n{element} ADDED IN QUEUE");
        }

        //method for deque operation
        public void Dequeue()
        {
            //if both stacks are empty
            if (stack1.Count == 0 && stack2.Count == 0)
            {
                Console.WriteLine("\nQUEUE IS EMPTY");
                return;
            }

            //move elements if stack2 is empty
            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            //variable to store removed element
            int removed = stack2.Pop();

            Console.WriteLine($"\n{removed} REMOVED FROM QUEUE");
        }

        //method for peek operation
        public void Peek()
        {
            //if both stacks are empty
            if (stack1.Count == 0 && stack2.Count == 0)
            {
                Console.WriteLine("\nQUEUE IS EMPTY");
                return;
            }
            //if stack2 is empty
            if (stack2.Count == 0)
            {
                //move elements
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            Console.WriteLine("\nELEMENT AT FRONT IS : " + stack2.Peek());
        }
    }
}
