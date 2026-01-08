using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_linked_list
{
    internal class BookNode
    {
        //book attributes
        public string bookTitle;
        public string author;
        public string genre;
        public int bookId;
        public bool isAvailable;

        //pointer to next and previous node
        public BookNode next;
        public BookNode prev;

        //constructor to initialize book node
        public BookNode(string bookTitle, string author, string genre, int bookId, bool isAvailable)
        {
            this.bookTitle = bookTitle;
            this.author = author;
            this.genre = genre;
            this.bookId = bookId;
            this.isAvailable = isAvailable;
            this.next = null;
            this.prev = null;
        }
    }

    class LibrarySystem
    {
        //head and tail of the doubly linked list
        private BookNode head;
        private BookNode tail;

        //method to add book at beginning
        public void AddAtBeginning(BookNode node)
        {
            //if list is empty then head and tail become the new node
            if (head == null)
            {
                head = tail = node;
                return;
            }

            //link new node to current head and update head
            node.next = head;
            head.prev = node;
            head = node;
        }

        //method to add book at last
        public void AddAtLast(BookNode node)
        {
            //if list is empty then head and tail become new node
            if (tail == null)
            {
                head = tail = node;
                return;
            }

            //link new node after tail and update tail
            tail.next = node;
            node.prev = tail;
            tail = node;
        }

        //method to add book at specific position
        public void AddAtPosition(BookNode node, int position)
        {
            //if position is 1 or list is empty then add at beginning
            if (position <= 1 || head == null)
            {
                AddAtBeginning(node);
                return;
            }

            //traverse to node before desired position
            BookNode temp = head;
            int count = 1;
            while (temp.next != null && count < position - 1)
            {
                temp = temp.next;
                count++;
            }

            //insert node at desired position
            node.next = temp.next;
            node.prev = temp;

            if (temp.next != null)
            {
                temp.next.prev = node;
            }
            else
            {
                //update tail if added at end
                tail = node; 
            }

            temp.next = node;
        }

        //method to remove book by book ID
        public void RemoveBook(int bookId)
        {
            //if list is empty
            if (head == null)
            {
                Console.WriteLine("NO BOOKS IN LIBRARY");
                return;
            }

            //if head is the book to remove
            if (head.bookId == bookId)
            {
                head = head.next;
                if (head != null)
                {
                    head.prev = null;
                }
                else
                {
                    tail = null;
                }
                Console.WriteLine("BOOK REMOVED SUCCESSFULLY");
                return;
            }

            //traverse to find the book
            BookNode temp = head;
            while (temp != null)
            {
                if (temp.bookId == bookId)
                {
                    if (temp.next != null)
                    {
                        temp.next.prev = temp.prev;
                    }
                    else
                    {
                        //update tail if last node
                        tail = temp.prev;
                    }

                    temp.prev.next = temp.next;

                    Console.WriteLine("BOOK REMOVED SUCCESSFULLY");
                    return;
                }
                temp = temp.next;
            }

            Console.WriteLine("BOOK NOT FOUND");
        }

        //method to search book by title
        public void SearchByTitle(string title)
        {
            BookNode temp = head;
            bool found = false;

            //traverse list to find title
            while (temp != null)
            {
                if (temp.bookTitle.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayBook(temp);
                    found = true;
                }
                temp = temp.next;
            }

            if (!found)
            {
                Console.WriteLine("BOOK NOT FOUND");
            }
        }

        //method to search book by author
        public void SearchByAuthor(string author)
        {
            BookNode temp = head;
            bool found = false;

            //traverse list to find author
            while (temp != null)
            {
                if (temp.author.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayBook(temp);
                    found = true;
                }
                temp = temp.next;
            }

            if (!found)
            {
                Console.WriteLine("BOOK NOT FOUND");
            }
        }

        //method to update availability status
        public void UpdateAvailability(int bookId, bool availability)
        {
            BookNode temp = head;

            //traverse list to find book
            while (temp != null)
            {
                if (temp.bookId == bookId)
                {
                    temp.isAvailable = availability;
                    Console.WriteLine("AVAILABILITY STATUS UPDATED");
                    return;
                }
                temp = temp.next;
            }

            Console.WriteLine("BOOK NOT FOUND");
        }

        //method to display a single book
        public void DisplayBook(BookNode book)
        {
            Console.WriteLine("\nBOOK ID: " + book.bookId);

            Console.WriteLine("BOOK TITLE: " + book.bookTitle);

            Console.WriteLine("AUTHOR: " + book.author);

            Console.WriteLine("GENRE: " + book.genre);

            Console.WriteLine("AVAILABLE: " + (book.isAvailable ? "YES" : "NO"));

            Console.WriteLine("---------------------------------------");
        }

        //method to display all books forward
        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("NO BOOKS IN LIBRARY");
                return;
            }

            BookNode temp = head;
            while (temp != null)
            {
                DisplayBook(temp);
                temp = temp.next;
            }
        }

        //method to display all books in reverse
        public void DisplayReverse()
        {
            if (tail == null)
            {
                Console.WriteLine("NO BOOKS IN LIBRARY");
                return;
            }

            BookNode temp = tail;
            while (temp != null)
            {
                DisplayBook(temp);
                temp = temp.prev;
            }
        }

        //method to count total books
        public void CountBooks()
        {
            int count = 0;
            BookNode temp = head;

            while (temp != null)
            {
                count++;
                temp = temp.next;
            }

            Console.WriteLine("TOTAL BOOKS IN LIBRARY: " + count);
        }

        //main method
        public static void Main(string[] args)
        {
            //create library system object
            LibrarySystem library = new LibrarySystem();

            //create some books
            BookNode book1 = new BookNode("The Alchemist", "Paulo Coelho", "Fiction", 101, true);

            BookNode book2 = new BookNode("1984", "George Orwell", "Dystopian", 102, true);

            BookNode book3 = new BookNode("Clean Code", "Robert Martin", "Programming", 103, true);

            BookNode book4 = new BookNode("The Pragmatic Programmer", "Andrew Hunt", "Programming", 104, true);

            //add books at beginning
            library.AddAtBeginning(book1);
            Console.WriteLine("BOOK ADDED AT BEGINNING: The Alchemist");

            //add books at last
            library.AddAtLast(book2);
            library.AddAtLast(book3);
            Console.WriteLine("BOOKS ADDED AT LAST: 1984, Clean Code");

            //add book at specific position
            library.AddAtPosition(book4, 2);
            Console.WriteLine("BOOK ADDED AT POSITION 2: The Pragmatic Programmer");

            //display all books forward
            Console.WriteLine("\nDISPLAYING ALL BOOKS FORWARD:");
            library.DisplayForward();

            //display all books reverse
            Console.WriteLine("\nDISPLAYING ALL BOOKS IN REVERSE:");
            library.DisplayReverse();

            //search book by title
            Console.WriteLine("\nSEARCH BOOK BY TITLE '1984':");
            library.SearchByTitle("1984");

            //search book by author
            Console.WriteLine("\nSEARCH BOOK BY AUTHOR 'Robert Martin':");
            library.SearchByAuthor("Robert Martin");

            //update availability
            Console.WriteLine("\nUPDATING AVAILABILITY OF BOOK ID 103 TO FALSE");
            library.UpdateAvailability(103, false);

            //display all books after availability update
            Console.WriteLine("\nDISPLAYING ALL BOOKS AFTER AVAILABILITY UPDATE:");
            library.DisplayForward();

            //remove a book
            Console.WriteLine("\nREMOVING BOOK ID 101 (The Alchemist)");
            library.RemoveBook(101);

            //display all books after removal
            Console.WriteLine("\nDISPLAYING ALL BOOKS AFTER REMOVAL:");
            library.DisplayForward();

            //count total books
            Console.WriteLine("\nCOUNTING TOTAL BOOKS:");
            library.CountBooks();
        }
    }
}
