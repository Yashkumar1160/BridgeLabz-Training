using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techville.modules;

//M-10 Citizen Network System
namespace techville.datastructures
{
    public class DoubleNode
    {
        //store citizen
        public Citizen Data;

        //next reference
        public DoubleNode Next;

        //previous reference
        public DoubleNode Prev;

        //Constructor
        public DoubleNode(Citizen citizen)
        {
            Data = citizen;
        }
    }

    //Doubly Linked List
    public class DoublyLinkedList
    {
        //head node
        private DoubleNode head;

        //method to insert at end
        public void Insert(Citizen citizen)
        {
            DoubleNode newNode = new DoubleNode(citizen);

            //if list empty
            if (head == null)
            {
                head = newNode;
                return;
            }

            //traverse to last node
            DoubleNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            
            //add new node
            temp.Next = newNode;
            newNode.Prev = temp;
        }

        //method for forward traversal
        public void DisplayForward()
        {
            DoubleNode temp = head;

            while (temp != null)
            {
                Console.WriteLine(temp.Data.Name);
                temp = temp.Next;
            }
        }

        //method for backward traversal
        public void DisplayBackward()
        {
            if (head == null) return;

            DoubleNode temp = head;

            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            //traverse backward
            while (temp != null)
            {
                Console.WriteLine(temp.Data.Name);
                temp = temp.Prev;
            }
        }
    }
}