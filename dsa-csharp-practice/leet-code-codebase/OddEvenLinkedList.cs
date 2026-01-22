using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.leet_code_codebase
{
    public class ListNode
    {
        //attributes 
        public int val;
        public ListNode next;

        //constructor 
        public ListNode(int value)
        {
            val = value;
            next = null;
        }
    }

    internal class OddEvenLinkedList
    {
        //head node
        ListNode head;

        //method to add a node at the end of linked list
        public void AddNode(int data)
        {
            //create new node
            ListNode node = new ListNode(data); 

            //if list is empty, new node becomes head
            if (head == null)
            {
                head = node;
            }
            else
            {
                //traverse to the last node
                ListNode temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                //add new node at end
                temp.next = node;
            }
        }

        //method for OddEven list
        public ListNode OddEvenList(ListNode head)
        {
            //if list is empty or has only one node
            if (head == null)
            {
                return null;
            }

            //initialize pointers
            ListNode odd = head;          
            ListNode even = head.next;    
            ListNode evenHead = even;      
            ListNode oddHead = odd;        

            //loop until even list or its next node becomes null
            while (even != null && even.next != null)
            {
                odd.next = odd.next.next;   
                even.next = even.next.next; 

                odd = odd.next;            
                even = even.next;           
            }

            if (even != null)
            {
                even.next = null;
            }


            odd.next = evenHead;

            return oddHead;
        }

        //method to display linked list
        public void DisplayList()
        {
            ListNode temp = head;
            while (temp != null)
            {
                Console.Write(temp.val + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }

        public static void Main()
        {
            OddEvenLinkedList list = new OddEvenLinkedList();

            list.AddNode(1);
            list.AddNode(2);
            list.AddNode(3);
            list.AddNode(4);
            list.AddNode(5);

            Console.WriteLine("Original List:");
            list.DisplayList();

            list.head = list.OddEvenList(list.head);

            Console.WriteLine("Odd-Even Reordered List:");
            list.DisplayList();
        }
    }
}
