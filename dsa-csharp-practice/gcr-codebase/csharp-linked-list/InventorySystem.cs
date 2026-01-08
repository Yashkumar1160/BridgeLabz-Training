using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_linked_list
{
    internal class ItemNode
    {
        //item attributes
        public int itemId;
        public string itemName;
        public int quantity;
        public double price;

        //pointer to next node in singly linked list
        public ItemNode next;

        //constructor 
        public ItemNode(int itemId, string itemName, int quantity, double price)
        {
            this.itemId = itemId;
            this.itemName = itemName;
            this.quantity = quantity;
            this.price = price;
            this.next = null;
        }
    }

    class InventorySystem
    {
        //head node 
        private ItemNode head;

        //method to add item at beginning
        public void AddAtBeginning(ItemNode node)
        {
            //if list is empty then head becomes the new node
            if (head == null)
            {
                head = node;
                return;
            }

            //link new node to current head and update head
            node.next = head;
            head = node;
        }

        //method to add item at last
        public void AddAtLast(ItemNode node)
        {
            //if list is empty then head becomes new node
            if (head == null)
            {
                head = node;
                return;
            }

            //traverse to the last node
            ItemNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            //link new node at the end
            temp.next = node;
        }

        //method to add item at specific position
        public void AddAtPosition(ItemNode node, int position)
        {
            //if position is 1 or list is empty then add at beginning
            if (position <= 1 || head == null)
            {
                AddAtBeginning(node);
                return;
            }

            //traverse to the node before desired position
            ItemNode temp = head;
            int count = 1;
            while (temp.next != null && count < position - 1)
            {
                temp = temp.next;
                count++;
            }

            //insert node at desired position
            node.next = temp.next;
            temp.next = node;
        }

        //method to remove item by ID
        public void RemoveItem(int itemId)
        {
            //if list is empty
            if (head == null)
            {
                Console.WriteLine("NO ITEMS IN INVENTORY");
                return;
            }

            //if head is the item to remove
            if (head.itemId == itemId)
            {
                head = head.next;
                Console.WriteLine("ITEM REMOVED SUCCESSFULLY");
                return;
            }

            //traverse to find the item
            ItemNode temp = head;
            ItemNode prev = null;

            while (temp != null && temp.itemId != itemId)
            {
                prev = temp;
                temp = temp.next;
            }

            //if item not found
            if (temp == null)
            {
                Console.WriteLine("ITEM NOT FOUND");
                return;
            }

            //remove node by linking previous node to next
            prev.next = temp.next;
            Console.WriteLine("ITEM REMOVED SUCCESSFULLY");
        }

        //method to update quantity by item ID
        public void UpdateQuantity(int itemId, int newQuantity)
        {
            ItemNode temp = head;

            //traverse list to find item
            while (temp != null)
            {
                if (temp.itemId == itemId)
                {
                    temp.quantity = newQuantity;
                    Console.WriteLine("QUANTITY UPDATED SUCCESSFULLY");
                    return;
                }
                temp = temp.next;
            }

            Console.WriteLine("ITEM NOT FOUND");
        }

        //method to search by item ID
        public void SearchByItemId(int itemId)
        {
            ItemNode temp = head;

            while (temp != null)
            {
                if (temp.itemId == itemId)
                {
                    DisplayItem(temp);
                    return;
                }
                temp = temp.next;
            }

            Console.WriteLine("ITEM NOT FOUND");
        }

        //method to search by item name
        public void SearchByItemName(string itemName)
        {
            ItemNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.itemName.Equals(itemName, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayItem(temp);
                    found = true;
                }
                temp = temp.next;
            }

            if (!found)
            {
                Console.WriteLine("ITEM NOT FOUND");
            }
        }

        //method to calculate total inventory value
        public void CalculateTotalValue()
        {
            double total = 0;
            ItemNode temp = head;

            while (temp != null)
            {
                total += temp.price * temp.quantity;
                temp = temp.next;
            }

            Console.WriteLine("TOTAL INVENTORY VALUE: " + total);
        }

        //method to display a single item
        public void DisplayItem(ItemNode item)
        {
            Console.WriteLine("\nITEM ID: " + item.itemId);

            Console.WriteLine("ITEM NAME: " + item.itemName);

            Console.WriteLine("QUANTITY: " + item.quantity);

            Console.WriteLine("PRICE: " + item.price);

            Console.WriteLine("---------------------------------------");
        }

        //method to display all items
        public void DisplayAllItems()
        {
            if (head == null)
            {
                Console.WriteLine("NO ITEMS IN INVENTORY");
                return;
            }

            ItemNode temp = head;
            while (temp != null)
            {
                DisplayItem(temp);
                temp = temp.next;
            }
        }

        //main method 
        public static void Main(string[] args)
        {
            //create object
            InventorySystem inventory = new InventorySystem();

            //create some items
            ItemNode item1 = new ItemNode(101, "Laptop", 5, 50000);

            ItemNode item2 = new ItemNode(102, "Mouse", 20, 500);

            ItemNode item3 = new ItemNode(103, "Keyboard", 10, 1500);

            ItemNode item4 = new ItemNode(104, "Monitor", 7, 8000);

            //add items at beginning
            inventory.AddAtBeginning(item1);
            Console.WriteLine("ITEM ADDED AT BEGINNING: Laptop");

            //add items at last
            inventory.AddAtLast(item2);
            inventory.AddAtLast(item3);
            Console.WriteLine("ITEMS ADDED AT LAST: Mouse, Keyboard");

            //add item at specific position
            inventory.AddAtPosition(item4, 2);
            Console.WriteLine("ITEM ADDED AT POSITION 2: Monitor");

            //display all items
            Console.WriteLine("\nDISPLAYING ALL ITEMS:");
            inventory.DisplayAllItems();

            //search item by ID
            Console.WriteLine("\nSEARCH ITEM BY ID 103:");
            inventory.SearchByItemId(103);

            //search item by Name
            Console.WriteLine("\nSEARCH ITEM BY NAME 'Monitor':");
            inventory.SearchByItemName("Monitor");

            //update quantity
            Console.WriteLine("\nUPDATING QUANTITY OF ITEM ID 102 TO 25");
            inventory.UpdateQuantity(102, 25);

            //display all items after update
            Console.WriteLine("\nDISPLAYING ALL ITEMS AFTER QUANTITY UPDATE:");
            inventory.DisplayAllItems();

            //calculate total inventory value
            Console.WriteLine("\nCALCULATING TOTAL INVENTORY VALUE:");
            inventory.CalculateTotalValue();

            //remove an item
            Console.WriteLine("\nREMOVING ITEM ID 101 (Laptop)");
            inventory.RemoveItem(101);

            //display all items after removal
            Console.WriteLine("\nDISPLAYING ALL ITEMS AFTER REMOVAL:");
            inventory.DisplayAllItems();
        }
    }
}
