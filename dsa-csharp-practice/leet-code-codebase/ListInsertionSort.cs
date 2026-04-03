using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace BridgeLabz_Training.dsa_csharp_practice.leet_code_codebase
{
    internal class ListNode
    {
        //attributes
        public int data;
        public ListNode next;

        //constructor
        public ListNode(int data)
        {
            this.data = data;
            this.next = null;
        }
    }

    internal class ListInsertionSort
    {
        public static void Main(string[] args)
        {
            //take number of nodes
            Console.Write("Enter Number Of Nodes: ");
            int n = int.Parse(Console.ReadLine());

            //initialize head and tail
            ListNode head = null;
            ListNode tail = null;

            //loop to take elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Element: ");
                int data = int.Parse(Console.ReadLine());

                //create node
                ListNode newNode = new ListNode(data);

                //insert node at end
                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    tail.next = newNode;
                    tail = newNode;
                }
            }

            //call InsertionSortList method
            head = InsertionSortList(head);

            //display list
            Console.WriteLine("Sorted List:");
            DisplayList(head);
        }

        //method to sort linked list using insertion sort
        public static ListNode InsertionSortList(ListNode head)
        {
            //dummy node
            ListNode dummy = new ListNode(0);

            //loop through list
            while (head != null)
            {
                //store next node
                ListNode nextNode = head.next;

                //previous node
                ListNode prev = dummy;

                while (prev.next != null && prev.next.data < head.data)
                {
                    prev = prev.next;
                }

                //insert current node into sorted list
                head.next = prev.next;
                prev.next = head;

                //move to next node
                head = nextNode;
            }

            return dummy.next;
        }

        //method to display linked list
        public static void DisplayList(ListNode head)
        {
            while (head != null)
            {
                Console.Write(head.data + " ");
                head = head.next;
            }
        }
    }
}
