using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_this_sealed_static_keywords
{
    internal class Book
    {
        //static variable to store library name
        public static string libraryName = "CENTRAL LIBRARY";

        //instance variables
        private string title;

        private string author;

        public readonly string isbn;

        //create parameterized constructor
        public Book(string title, string author, string isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
        }

        public static void Main(string[] args)
        {
            //call the TakeInputs method
            TakeInputs();
        }


        //--------------TAKE INPUTS-----------------
        //method to take user inputs
        public static void TakeInputs()
        {
            //display library name
            Console.WriteLine(libraryName);

            //take title input
            Console.Write("\nENTER BOOK TITLE: ");
            string title = Console.ReadLine();

            //take author input
            Console.Write("ENTER BOOK AUTHOR: ");
            string author = Console.ReadLine();

            //take isbn input
            Console.Write("ENTER BOOK ISBN: ");
            string isbn = Console.ReadLine();
            Console.WriteLine();

            //create object
            Book book = new Book(title, author, isbn);

            //check if object is of class type
            if (book is Book)
            {
                DisplayLibraryName();
                book.DisplayDetails();
            }
        }

        //---------------DISPLAY DETAILS-----------------
        //method to display all details of book
        public void DisplayDetails()
        {
            Console.WriteLine("\nBOOK DETAILS: ");

            Console.WriteLine("BOOK TITLE: " + title);

            Console.WriteLine("BOOK AUTHOR: " + author);

            Console.WriteLine("BOOK ISBN: " + isbn);

        }

        //------------DISPLAY LIBRARY NAME---------------
        //method to display library name
        public static void DisplayLibraryName()
        {
            Console.WriteLine(libraryName);
        }
    }
}
