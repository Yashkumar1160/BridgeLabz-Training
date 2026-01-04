using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.level_1
{
    internal class LibraryBook
    {
        //attributes to store data

        string title;

        string author;

        double price;

        bool availability;

        //create default constructor
        public LibraryBook()
        {
            //store default values
            title = "DOOMSDAY";

            author = "MARVEL";

            price = 500;

            availability = true;
        }

        //create parameterized constructor
        public LibraryBook(string title, string author, double price, bool availability)
        {
            //initialize values
            this.title = title;

            this.author = author;

            this.price = price;

            this.availability = availability;

        }

        public static void Main(string[] args)
        {
            //create object using default constructor
            LibraryBook libBook1 = new LibraryBook();

            Console.Write("ENTER BOOK TITLE: ");
            string title = Console.ReadLine();

            Console.Write("ENTER BOOK AUTHOR: ");
            string author = Console.ReadLine();

            Console.Write("ENTER BOOK PRICE: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("ENTER BOOK AVAILABILITY: ");
            bool availability = Convert.ToBoolean(Console.ReadLine());

            //create object using parameterized constructor
            LibraryBook libBook2 = new LibraryBook(title, author, price, availability);

            //call the DisplayBookDetails method for both before borrowing
            libBook1.DisplayBookDetails();

            libBook2.DisplayBookDetails();

            //call the BorrowBook method for both
            libBook1.BorrowBook();

            libBook2.BorrowBook();

            //call the DisplayBookDetails method for both after borrowing
            libBook1.DisplayBookDetails();

            libBook2.DisplayBookDetails();
        }

        //---------------BORROW BOOK-----------------
        //method to borrow a book
        public void BorrowBook()
        {
            //check if book is available or not
            if (availability)
            {
                availability = false;

                Console.WriteLine("\nBOOK BORROWED SUCCESSFULLY");
            }
            else
            {
                Console.WriteLine("\nBOOK IS NOT AVAILABLE");
            }
        }

        //-------------DISPLAY BOOK DETAILS------------------
        //method to display book details
        public void DisplayBookDetails()
        {
            Console.WriteLine("\nBOOK TITLE: " + title);

            Console.WriteLine("BOOK AUTHOR: " + author);

            Console.WriteLine("BOOK PRICE: " + price);

            Console.WriteLine("BOOK AVAILABLE: " + availability);

            Console.WriteLine();
        }



    }
}
