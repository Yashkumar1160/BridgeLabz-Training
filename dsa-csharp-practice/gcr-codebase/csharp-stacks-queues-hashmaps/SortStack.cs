using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_stacks_queues_hashmaps
{
    internal class SortStack
    {
        public static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < 5; i++)
            {
                //take a number input
                Console.Write("ENTER A NUMBER: ");
                int number = Convert.ToInt32(Console.ReadLine());

                //push element to stack
                stack.Push(number);
            }

            //display stack before sorting
            Console.WriteLine("STACK BEFORE SORTING: ");
            foreach (int i in stack)
            {
                Console.Write(i + " ");
            }

            //call RecursiveSort method
            RecursiveSort(stack);

            //display stack after sorting
            Console.WriteLine("\nSTACK AFTER SORTING: ");
            foreach (int i in stack)
            {
                Console.Write(i + " ");
            }

        }

        //method to sort stack recursively
        public static void RecursiveSort(Stack<int> stack)
        {

            //base condition
            if (stack.Count == 0)
                return;

            //remove the element present at top
            int top = stack.Pop();

            //sort the remaining stack
            RecursiveSort(stack);

            //add element at correct position
            AddElement(stack, top);
        }

        //metheod to add element at correct position
        public static void AddElement(Stack<int> stack, int element)
        {
            //if stack is empty or element is greater than top 
            if (stack.Count == 0 || element <= stack.Peek())
            {
                //push element
                stack.Push(element);
                return;
            }

            // Remove top element
            int temp = stack.Pop();

            //recursive call for AddElement method
            AddElement(stack, element);

            //push removed element back
            stack.Push(temp);
        }
    }
}
