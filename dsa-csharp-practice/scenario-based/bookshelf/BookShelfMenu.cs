using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.bookshelf
{
    internal class BookShelfMenu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("--------BOOK SHELF SYSTEM----------");

            //create object of BookShelfUtilityImpl class
            BookShelfUtilityImpl manager = new BookShelfUtilityImpl();

            //infinite loop until user exits
            while (true)
            {
                //display choices
                Console.WriteLine("\n1. ADD BOOK");
                Console.WriteLine("2. ADD GENRE");
                Console.WriteLine("3. REMOVE GENRE");
                Console.WriteLine("4. BORROW BOOK");
                Console.WriteLine("5. RETURN BOOK");
                Console.WriteLine("6. DISPLAY BOOKS");
                Console.WriteLine("7. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice=Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch(choice)
                {
                    //add book at first
                    case 1:
                        
                        //take genre
                        Console.Write("\nENTER GENRE: ");
                        string genre=Console.ReadLine();

                        //check if genre exists
                        if (!manager.CheckGenre(genre))
                        {
                            Console.WriteLine("GENRE DOES NOT EXIST. PLEASE ADD GENRE FIRST");
                            break;
                        }

                        //take book number
                        Console.Write("ENTER BOOK NUMBER: ");
                        int bookNumber=Convert.ToInt32(Console.ReadLine());

                        if (manager.CheckBookNumber(bookNumber))
                        {
                            Console.WriteLine("\nBOOK ALREADY EXISTS WITH THIS BOOK NUMBER");
                            break;
                        }

                        //take book title
                        Console.Write("ENTER BOOK TITLE: ");
                        string bookTitle=Console.ReadLine();

                        //take book author
                        Console.Write("ENTER BOOK AUTHOR: ");
                        string bookAuthor=Console.ReadLine();

                        //add book
                        manager.AddBook(genre,bookNumber,bookTitle,bookAuthor);
                        break;


                    //add book at last
                    case 2:

                        //take genre
                        Console.Write("\nENTER GENRE: ");
                        string genreToAdd = Console.ReadLine();

                        //check if genre already exists
                        if (manager.CheckGenre(genreToAdd))
                        {
                            Console.WriteLine("GENRE ALREADY EXISTS");
                            break;
                        }

                        //if genre does not exists then add genre
                        manager.AddGenre(genreToAdd);
                        break;


                    //remove genre
                    case 3:

                        //take genre
                        Console.Write("\nENTER GENRE: ");
                        string genreToRemove = Console.ReadLine();

                        if (manager.CheckGenre(genreToRemove))
                        {
                            manager.RemoveGenre(genreToRemove);
                        }
                        else
                        {
                            Console.WriteLine("GENRE DOES NOT EXISTS");
                        }
                        break;


                    //borrow book 
                    case 4:

                        //take book number 
                        Console.Write("\nENTER BOOK NUMBER: ");
                        int borrowBook=Convert.ToInt32(Console.ReadLine());

                        manager.BorrowBook(borrowBook);
                        break;


                    //return book
                    case 5:

                        //take book number
                        Console.Write("\nENTER BOOK NUMBER: ");
                        int returnBook=Convert.ToInt32(Console.ReadLine());

                        manager.ReturnBook(returnBook);
                        break;


                    //display all books by genre
                    case 6:
                        manager.DisplayBooksByGenre();
                        break;


                    //exit
                    case 7:
                        Console.WriteLine("\nEXIT SUCCESSFUL");
                        return;


                    default:
                        Console.WriteLine("\nINVALID CHOICE");
                        break;

                }


            }
        }
    }
}
