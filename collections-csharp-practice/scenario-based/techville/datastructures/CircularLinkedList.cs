using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techville.modules;

//M-10 Citizen Network System
namespace techville.datastructures
{
    //CircularNode
    public class CircularNode
    {
        //store citizen
        public Citizen Data;

        //next reference
        public CircularNode Next;

        //Constructor
        public CircularNode(Citizen citizen)
        {
            Data = citizen;
        }
    }

    //Circular Linked List
    public class CircularLinkedList
    {
        //head and tail nodes
        private CircularNode head;
        private CircularNode tail;

        //method to insert citizen
        public void Insert(Citizen citizen)
        {
            CircularNode newNode = new CircularNode(citizen);

            //if list empty
            if (head == null)
            {
                head = tail = newNode;
                tail.Next = head;
                return;
            }

            //add at end
            tail.Next = newNode;
            tail = newNode;

            //point last to head
            tail.Next = head;
        }

        //method to display circular list
        public void Display(int rounds)
        {
            if (head == null)
            {
                Console.WriteLine("No citizens");
                return;
            }

            CircularNode temp = head;
            int count = 0;

            while (count < rounds)
            {
                Console.WriteLine(temp.Data.Name);
                temp = temp.Next;
                count++;
            }
        }
    }
}