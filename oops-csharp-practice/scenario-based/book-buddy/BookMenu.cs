using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.book_buddy
{
    internal class BookMenu
    {
        public static void Start()
        {
            Console.WriteLine("------BOOK BUDDY------");

            //create instance of BookUtilityImpl class
            BookUtilityImpl bookUtilityImpl = new BookUtilityImpl();


            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\n1. ADD BOOK");
                Console.WriteLine("2. SORT BOOKS ALPHABETICALLY");
                Console.WriteLine("3. SEARCH BY AUTHOR");
                Console.WriteLine("4. SEARCH BY TITLE");
                Console.WriteLine("5. DISPLAY ALL BOOKS");
                Console.WriteLine("6. EXIT PROGRAM");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice=Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch(choice)
                {
                    //add book
                    case 1:
                        Console.WriteLine("ENTER BOOK TITLE: ");
                        string bookTitle=Console.ReadLine();

                        Console.WriteLine("ENTER BOOK AUTHOR: ");
                        string author=Console.ReadLine();

                        Book book = new Book(bookTitle, author);

                        bookUtilityImpl.AddBook(bookTitle,author);
                        break;

                    //sort books
                    case 2:
                        bookUtilityImpl.SortBooksAlphabetically();
                        Console.WriteLine("SORTED BOOKS");
                        break;

                    //search by author
                    case 3:
                        Console.WriteLine("ENTER AUTHOR NAME: ");

                        string authorName=Console.ReadLine();

                        bookUtilityImpl.SearchByAuthor(authorName);
                        break;

                    //search by title
                    case 4:
                        Console.Write("ENTER TITLE: ");
                        string title=Console.ReadLine();    

                        bookUtilityImpl.SearchByTitle(title);
                        break;

                    //display all books
                    case 5:
                        bookUtilityImpl.DisplayAllBooks();
                        break;

                    case 6:
                        Console.WriteLine("EXIT SUCCESSFUL");
                        return;

                    default:
                        Console.WriteLine("INVALID INPUT");
                        break;
                }
            }
        }
    }
}
