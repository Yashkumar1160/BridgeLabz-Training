using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class FindNthElement
    {
        public static void Main(string[] args)
        {
            //linked list to store letters
            LinkedList<string> letters = new LinkedList<string>();

            //take number of elements
            Console.Write("Enter Number Of Elements: ");
            int numberOfElements = Convert.ToInt32(Console.ReadLine());

            //loop to take elements
            for (int i = 0; i < numberOfElements; i++)
            {
                //take element
                Console.Write("Enter Element: ");
                string value = Console.ReadLine();
                letters.AddLast(value);
            }

            //take n value
            Console.Write("Enter N value: ");
            int n = Convert.ToInt32(Console.ReadLine());

            //call FindNthFromEnd method
            FindNthFromEnd(letters, n);
        }


        //method to find nth element from end
        public static void FindNthFromEnd(LinkedList<string> letters, int n)
        {
            //first pointer
            LinkedListNode<string> first = letters.First;

            //second pointer
            LinkedListNode<string> second = letters.First;

            //move first pointer n steps ahead
            for (int i = 0; i < n; i++)
            {
                first = first.Next;
            }

            //move both pointers together
            while (first != null)
            {
                first = first.Next;
                second = second.Next;
            }

            Console.WriteLine("Nth Element From End: " + second.Value);
        }
    }
}

