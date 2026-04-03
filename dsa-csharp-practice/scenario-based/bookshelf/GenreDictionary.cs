using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.bookshelf
{
    internal class GenreDictionary
    {
        //head node of linked list
        private GenreNode head;


        //method to add a new genre
        public bool Add(string genre)
        {
            //check if genre already exists
            if (ContainsKey(genre))
            {
                return false;
            }

            //create new genre node
            GenreNode node = new GenreNode(genre);

            //if dictionary is empty
            if (head == null)
            {
                head = node;
                return true;
            }

            //traverse till last node
            GenreNode temp = head;
            while (temp.next != null)
                temp = temp.next;

            //add new genre at last
            temp.next = node;
            return true;
        }



        //method to check if a genre exists
        public bool ContainsKey(string genre)
        {
            GenreNode temp = head;

            //loop through linked list
            while (temp != null)
            {
                //if genre matches
                if (temp.genre.Equals(genre))
                {
                    return true;
                }

                temp = temp.next;
            }
            return false;
        }


        //method to get book list of a specific genre
        public BookListUtilityImpl Get(string genre)
        {
            //start from head
            GenreNode temp = head;

            //loop through linked list
            while (temp != null)
            {
                //if genre matches then return its book list
                if (temp.genre.Equals(genre))
                {
                    return temp.bookList;
                }
                temp = temp.next;
            }
            return null;
        }

        //method to remove a genre
        public bool Remove(string genre)
        {
            //if dictionary is empty
            if (head == null)
            {
                return false;
            }

            if (head.genre.Equals(genre))
            {
                head = head.next;
                return true;
            }

            //store previous and current nodes
            GenreNode prev = head;
            GenreNode curr = head.next;

            //loop through linked list
            while (curr != null)
            {
                if (curr.genre.Equals(genre))
                {
                    prev.next = curr.next;
                    return true;
                }

                prev = curr;
                curr = curr.next;
            }
            return false;
        }

        //method to get head node for traversal
        public GenreNode GetHead()
        {
            return head;
        }
    }
}
