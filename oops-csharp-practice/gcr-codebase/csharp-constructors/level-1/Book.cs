using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.level_1
{
    internal class Book
    {
        //attributes to store data

        string title;

        string author;

        double price;

        //create default constructor
        public Book()
        {
            //store default values
            title = "DOOMSDAY";

            author = "MARVEL";

            price = 500;
        }

        //create parameterized constructor
        public Book(string title, string author, double price)
        {
            //initialize values
            this.title = title;

            this.author = author;

            this.price = price;
        }

        public static void Main(string[] args)
        {
            //create object using default constructor
            Book defaultBook = new Book();

            Console.Write("ENTER BOOK TITLE: ");
            string title = Console.ReadLine();

            Console.Write("ENTER BOOK AUTHOR: ");
            string author = Console.ReadLine();

            Console.Write("ENTER BOOK PRICE: ");
            double price = Convert.ToDouble(Console.ReadLine());


            //create object using parameterized constructor
            Book parameterizedBook = new Book(title, author, price);

            //call the DisplayDetails method for both
            Console.WriteLine("\nRESULTS USING DEFALUT CONSTRUCTOR: ");
            defaultBook.DisplayDetails();

            Console.WriteLine("\nRESULTS USING PARAMETERIZED CONSTRUCTOR: ");
            parameterizedBook.DisplayDetails();

        }

        //---------------DISPLAY DETAILS-----------------
        //method to display book details
        public void DisplayDetails()
        {
            Console.WriteLine("BOOK TITLE: " + title);

            Console.WriteLine("BOOK AUTHOR: " + author);

            Console.WriteLine("BOOK PRICE: " + price);

        }

    }
}
