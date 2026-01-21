using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class ReverseAQueue
    {
        public static void Main(string[] args)
        {
            //create queue
            Queue<int> queue = new Queue<int>();

            //take number of elements
            Console.WriteLine("Enter Number of Elements:");
            int numberOfElements = Convert.ToInt32(Console.ReadLine());

            //loop to take elements
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write("Enter Element: ");
                queue.Enqueue(Convert.ToInt32(Console.ReadLine()));
            }

            //call Reverse method
            Reverse(queue);

            //display reversed queue
            Console.WriteLine("Reversed Queue:");
            foreach (int num in queue)
            {
                Console.Write(num + " ");
            }
        }

        //method to reverse queue
        public static void Reverse(Queue<int> queue)
        {
            //stack to store elements of queue
            Stack<int> stack = new Stack<int>();

            //move elements from queue to stack
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            //move elements back to queue
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
    }
}
