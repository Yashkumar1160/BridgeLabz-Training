using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techville.modules;

//M-10 Citizen Network System
namespace techville.datastructures
{
    //Single Node 
    public class SingleNode
    {
        //store citizen object
        public Citizen Data;
        //reference to next node
        public SingleNode Next;

        //Constructor
        public SingleNode(Citizen citizen)
        {
            Data = citizen;
            Next = null;
        }
    }

    //Singly Linked List
    public class SinglyLinkedList
    {
        //head node
        private SingleNode head;

        //method to insert citizen at end (Enqueue)
        public void Insert(Citizen citizen)
        {
            //create new node
            SingleNode newNode = new SingleNode(citizen);

            //if list is empty
            if (head == null)
            {
                head = newNode;
                return;
            }

            //traverse to last node
            SingleNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            //attach new node
            temp.Next = newNode;
        }

        //method to delete citizen from beginning(dequeue)
        public void Delete()
        {
            //check if list empty  
            if (head == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            Console.WriteLine("Removed: " + head.Data.Name);

            //move head to next node
            head = head.Next;
        }

        //method to display list
        public void Display()
        {
            SingleNode temp = head;

            while (temp != null)
            {
                Console.WriteLine(temp.Data.Name);
                temp = temp.Next;
            }
        }
    }
}