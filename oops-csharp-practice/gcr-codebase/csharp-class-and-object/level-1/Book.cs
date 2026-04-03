using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_class_and_object.level_1
{
    internal class Book
    {
        //attributes to store data

        string title;

        string author;

        double price;

        public static void Main(string[] args)
        {
            //create object of class
            Book book = new Book();

            //take book title input
            Console.Write("ENTER BOOK TITLE: ");
            book.title = Console.ReadLine();

            //take author input
            Console.Write("ENTER AUTHOR NAME: ");
            book.author = Console.ReadLine();

            //take price input
            Console.Write("ENTER BOOK PRICE: ");
            book.price = Convert.ToDouble(Console.ReadLine());

            //call DisplayDetails method
            book.DisplayDetails();

        }

        //-------------DISPLAY DETAILS-------------
        //method to display the details of book
        public void DisplayDetails()
        {
            //display book details
            Console.WriteLine("Book Title: " + title);

            Console.WriteLine("Author Name: " + author);

            Console.WriteLine("Book Price: " + price);
        }
    }
}
