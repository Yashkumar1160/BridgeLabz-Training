using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.bookshelf
{
    internal class BookListUtilityImpl : IBookList 
    {
        public BookNode head;

     
        //method to add book at last in linked list
        public void AddBookAtLast(BookNode node)
        {
            //if no book is present 
            if (head == null)
            {
                head = node;
                return;
            }

            //store head in book variable 
            BookNode book = head;

            //loop through linked list
            while (book.Next != null)
            {
                book = book.Next;
            }

            //add book at last
            book.Next = node;
            node.Next = null;

        }



        //method to search a book
        public BookNode SearchBook(int bookNumber)
        {
            //store head in book variable 
            BookNode book = head;

            //loop through linked list
            while (book!= null)
            {
                //if book is found
                if (book.bookNumber == bookNumber)
                {
                    return book;
                }

                book = book.Next;
            }

            //if book not found
            return null;
        }



        //method to update book status
        public void UpdateStatus(int bookNumber, bool status)
        {
            //search for the book
            BookNode book = SearchBook(bookNumber);

            //if book is found
            if (book != null)
            {
                //update status
                book.isAvailable = status;
                return;
            }

            //if book not found
            Console.WriteLine("\nBOOK NOT FOUND");

        }


        //method to display book data
        public void DisplayBook()
        {
            //store head in book node
            BookNode book = head;

            //loop until null
            while (book != null)
            {
                Console.WriteLine("\nBOOK NUMBER: " + book.bookNumber);
                
                Console.WriteLine("BOOK TITLE: " + book.bookTitle);
                
                Console.WriteLine("BOOK AUTHOR: " + book.bookAuthor);

                Console.WriteLine(book.isAvailable ? "BOOK STATUS: AVAILABLE" : "BOOK STATUS: NOT AVAILABLE");

                book=book.Next;
            }
        }
    }
}
