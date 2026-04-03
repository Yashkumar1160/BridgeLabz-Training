using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_stacks_queues_hashmaps
{
    //node class for linked list in each bucket
    class Node
    {
        //attributes
        public int Key;
        public int Value;
        public Node Next;

        //constructor
        public Node(int key, int value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }

    //Custom Dictionary class
    class CustomDictionary
    {
        //number of buckets
        private int size = 100;

        //array of linked list heads
        private Node[] buckets;

        public CustomDictionary()
        {
            buckets = new Node[size];
        }

        //simple hash function
        private int GetHash(int key)
        {
            return key % size;
        }

        //method to add or update key-value pair
        public void Add(int key, int value)
        {
            int index = GetHash(key);
            Node head = buckets[index];
            Node current = head;

            //check if key exists then update value if found
            while (current != null)
            {
                if (current.Key == key)
                {
                    current.Value = value;
                    return;
                }
                current = current.Next;
            }

            //insert new node at head
            Node newNode = new Node(key, value);
            newNode.Next = head;
            buckets[index] = newNode;
        }

        //get value by key 
        public int Get(int key)
        {
            int index = GetHash(key);
            Node current = buckets[index];

            while (current != null)
            {
                if (current.Key == key)
                    return current.Value;
                current = current.Next;
            }


            //if key not found
            return 0;
        }

        //method to remove key-value pair
        public bool Remove(int key)
        {
            int index = GetHash(key);
            Node current = buckets[index];
            Node prev = null;

            while (current != null)
            {
                if (current.Key == key)
                {
                    if (prev == null)
                        buckets[index] = current.Next;
                    else
                        prev.Next = current.Next;
                    return true;
                }
                prev = current;
                current = current.Next;
            }

            //if key not found
            return false;
        }

        //check if key exists
        public bool ContainsKey(int key)
        {
            int index = GetHash(key);
            Node current = buckets[index];

            while (current != null)
            {
                if (current.Key == key)
                    return true;
                current = current.Next;
            }

            return false;
        }
    }

    class Program
    {
        public static void Main()
        {
            CustomDictionary dict = new CustomDictionary();

            //add values
            dict.Add(1, 100);
            dict.Add(2, 200);

            //update existing key
            dict.Add(2, 250);

            //get values
            Console.WriteLine("Value for key 1: " + dict.Get(1));
            Console.WriteLine("Value for key 2: " + dict.Get(2));
            Console.WriteLine("Value for key 3 (not present): " + dict.Get(3));

            //check key existence
            Console.WriteLine("Contains key 2? " + dict.ContainsKey(2));
            Console.WriteLine("Contains key 3? " + dict.ContainsKey(3));

            //remove key
            dict.Remove(1);
            Console.WriteLine("Contains key 1 after removal? " + dict.ContainsKey(1));
        }
    }
}
