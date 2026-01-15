using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.leet_code_codebase
{
    class ListNode
    {
        //variable to store data
        public int data;       
        
        //variable to store address of next node
        public ListNode Next;   

        //constructor
        public ListNode(int data)
        {
            this.data = data;
            this.Next = null;
        }
    }

    internal class ReverseLinkedList
    {
        public static void Main(string[] args)
        {
            //create linked list
            ListNode head = new ListNode(1);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(3);
            head.Next.Next.Next = new ListNode(4);

            Console.WriteLine("ORIGINAL LINKED LIST:");
            PrintList(head);

            //reverse the linked list
            ReverseLinkedList obj = new ReverseLinkedList();

            head = obj.ReverseList(head);

            Console.WriteLine("REVERSED LINKED LIST:");
            PrintList(head);
        }

        //method to reverse linked list
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            ListNode next;

            while (curr != null)
            {
                //store next node
                next = curr.Next;

                //reverse link
                curr.Next = prev;

                //move prev forward
                prev = curr;

                //move curr forward
                curr = next;      
            }

            //return new head of reversed list
            return prev; 
        }

        //method to display linked list
        public static void PrintList(ListNode head)
        {
            ListNode temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.Next;
            }
            Console.WriteLine("null");
        }
    }
}
