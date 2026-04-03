using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_linked_list
{
    internal class TextStateNode
    {
        //text state attributes
        public string content;

        //pointers for doubly linked list
        public TextStateNode prev;

        public TextStateNode next;

        //constructor
        public TextStateNode(string content)
        {
            this.content = content;
            this.prev = null;
            this.next = null;
        }
    }

    class TextEditor
    {
        //head and tail nodes
        private TextStateNode head;
        private TextStateNode tail;

        //pointer to current state
        private TextStateNode current;

        //maximum history size
        private int maxHistory = 10;
        private int count = 0;

        //method to add new text state
        public void AddState(string content)
        {
            //create new node
            TextStateNode node = new TextStateNode(content);

            //if list is empty
            if (head == null)
            {
                head = tail = current = node;
                count = 1;
                return;
            }

            //if current is not tail, remove all redo states after current
            TextStateNode temp = current.next;
            while (temp != null)
            {
                TextStateNode next = temp.next;
                temp.prev = null;
                temp.next = null;
                temp = next;
                count--;
            }

            //link new node after current
            current.next = node;
            node.prev = current;
            tail = node;
            current = node;
            count++;

            //limit history size to maxHistory
            while (count > maxHistory)
            {
                //remove oldest node (head)
                head = head.next;
                head.prev = null;
                count--;
            }
        }

        //method to undo
        public void Undo()
        {
            if (current == null || current.prev == null)
            {
                Console.WriteLine("NO MORE UNDO AVAILABLE");
                return;
            }

            current = current.prev;
            Console.WriteLine("UNDO SUCCESSFUL");
            DisplayCurrentState();
        }

        //method to redo
        public void Redo()
        {
            if (current == null || current.next == null)
            {
                Console.WriteLine("NO MORE REDO AVAILABLE");
                return;
            }

            current = current.next;
            Console.WriteLine("REDO SUCCESSFUL");
            DisplayCurrentState();
        }

        //method to display current state
        public void DisplayCurrentState()
        {
            if (current == null)
            {
                Console.WriteLine("NO TEXT AVAILABLE");
                return;
            }

            Console.WriteLine("\nCURRENT TEXT STATE:");
            Console.WriteLine(current.content);
        }

        //main method
        public static void Main(string[] args)
        {
            //create object of TextEditor
            TextEditor editor = new TextEditor();

            //add new states as user types
            editor.AddState("Hello");
            Console.WriteLine("ADDED TEXT: 'Hello'");

            editor.AddState("Hello World");
            Console.WriteLine("ADDED TEXT: 'Hello World'");

            editor.AddState("Hello World!");
            Console.WriteLine("ADDED TEXT: 'Hello World!'");

            //display current state
            editor.DisplayCurrentState();

            //perform undo
            Console.WriteLine("\nPERFORMING UNDO:");
            editor.Undo();

            //perform undo again
            Console.WriteLine("\nPERFORMING UNDO:");
            editor.Undo();

            //perform redo
            Console.WriteLine("\nPERFORMING REDO:");
            editor.Redo();

            //add new state after undo (should remove redo history)
            editor.AddState("Hello Everyone!");
            Console.WriteLine("ADDED TEXT: 'Hello Everyone!'");

            //display current state
            editor.DisplayCurrentState();

            //perform undo
            Console.WriteLine("\nPERFORMING UNDO:");
            editor.Undo();

            //perform redo
            Console.WriteLine("\nPERFORMING REDO:");
            editor.Redo();
        }
    }
}

