using BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.bookshelf
{
    internal class BookShelfUtilityImpl : IBookShelf
    {

        //custom dictionary to store genres and their book lists
        private GenreDictionary bookShelf = new GenreDictionary();


        //method to add genre
        public void AddGenre(string genre)
        {
            //if genre does not exist
            if (bookShelf.Add(genre))
            {
                Console.WriteLine("\nNEW GENRE ADDED SUCCESSFULLY");
            }
            else
            { 
                Console.WriteLine("\nGENRE ALREADY EXISTS");
            }
        }



        //method to check if genre exists
        public bool CheckGenre(string genre)
        {
            return bookShelf.ContainsKey(genre);
        }



        //method to check for book number
        public bool CheckBookNumber(int bookNumber)
        {
            //start traversal from first genre
            GenreNode temp = bookShelf.GetHead();

            //loop through all genres
            while (temp != null)
            {
                //search book in current genre
                if (temp.bookList.SearchBook(bookNumber) != null)
                    return true;

                temp = temp.next;
            }
            return false;
        }



        //method to add book
        public void AddBook(string genre, int bookNumber, string bookTitle, string bookAuthor)
        {
            //store book list
            BookListUtilityImpl bookList = bookShelf.Get(genre);

            //if genre not found
            if (bookList == null)
            {
                Console.WriteLine("\nGENRE NOT FOUND");
                return;
            }

            //create book node
            BookNode book = new BookNode(bookNumber, bookTitle, bookAuthor);
           
            //add book at last
            bookList.AddBookAtLast(book);

            Console.WriteLine("\nBOOK ADDED SUCCESSFULLY");
        }



        //method to remove genre
        public void RemoveGenre(string genre)
        {
            //if genre exists and is removed
            if (bookShelf.Remove(genre))
            {
                Console.WriteLine("\nGENRE REMOVED SUCCESSFULLY");
            }
            else
            {
                Console.WriteLine("\nGENRE NOT FOUND");
            }
        }

        //method to borrow a book using book number
        public void BorrowBook(int bookNumber)
        {
            //start traversal from first genre
            GenreNode temp = bookShelf.GetHead();


            //loop through all genres
            while (temp != null)
            {
                //search book in current genre
                BookNode book = temp.bookList.SearchBook(bookNumber);

                //if book found
                if (book != null)
                {
                    //if book is already borrowed
                    if (!book.isAvailable)
                    {
                        Console.WriteLine("\nBOOK IS ALREADY BORROWED");
                        return;
                    }

                    //update status
                    book.isAvailable = false;
                    Console.WriteLine("\nBOOK BORROWED SUCCESSFULLY");
                    return;
                }

                temp = temp.next;
            }

            Console.WriteLine("\nBOOK NOT FOUND");
        }



        //method to return a book
        public void ReturnBook(int bookNumber)
        {
            //start traversal from first genre
            GenreNode temp = bookShelf.GetHead();

            //loop through all genres
            while (temp != null)
            {
                //search book in current genre
                BookNode book = temp.bookList.SearchBook(bookNumber);

                //if book found
                if (book != null)
                {
                    //if book is already available
                    if (book.isAvailable)
                    {
                        Console.WriteLine("\nBOOK IS ALREADY AVAILABLE");
                        return;
                    }

                    //update status
                    book.isAvailable = true;
                    Console.WriteLine("\nBOOK RETURNED SUCCESSFULLY");
                    return;
                }

                temp = temp.next;
            }

            Console.WriteLine("\nBOOK NOT FOUND");
        }



        //method to display books by their genre
        public void DisplayBooksByGenre()
        {
            GenreNode temp = bookShelf.GetHead();

            while (temp != null)
            {
                Console.WriteLine("\nBOOK GENRE: " + temp.genre);
                Console.WriteLine("----------------------------");

                temp.bookList.DisplayBook();
                temp = temp.next;
            }
        }
    }
}
