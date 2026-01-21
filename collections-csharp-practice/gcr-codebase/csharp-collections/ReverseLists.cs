using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class ReverseLists
    {
        public static void Main(string[] args)
        {
            //take number of elements
            Console.WriteLine("Enter Number Of Elements: ");
            int numberOfElements = Convert.ToInt32(Console.ReadLine());

            ArrayList numberList = new ArrayList();
            LinkedList<int> numbers = new LinkedList<int>();

            for (int i = 0; i < numberOfElements; i++)
            {
                //take number
                Console.Write("Enter Number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                numberList.Add(number);
                numbers.AddLast(number);
            }

            //call ReverseArrayList method
            ReverseArrayList(numberList);

            //call ReverseLinkedList method
            ReverseLinkedList(numbers);

        }

        //method to reverse array list
        public static void ReverseArrayList(ArrayList numberList)
        {
            int start = 0;
            int end = numberList.Count - 1;

            while (start < end)
            {
                // swap elements
                object temp = numberList[start];
                numberList[start] = numberList[end];
                numberList[end] = temp;

                start++;
                end--;
            }

            Console.WriteLine("Reversed Array List:");
            foreach (var item in numberList)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        //method to reverse linked list
        public static void ReverseLinkedList(LinkedList<int> numbers)
        {
            //store reversed linked list
            LinkedList<int> reversedList = new LinkedList<int>();

            //add elements at first position
            foreach (int value in numbers)
            {
                reversedList.AddFirst(value);
            }

            Console.WriteLine("Reversed Linked List:");
            foreach (int value in reversedList)
            {
                Console.Write(value + " ");
            }
        }
    }
}
