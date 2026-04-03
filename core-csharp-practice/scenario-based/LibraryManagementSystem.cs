using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Library Management System 30-12-2025
namespace BridgeLabzTraining.scenario_based
{
    internal class LibraryManagementSystem
    {
        //store admin details
        static string adminUsername = "yash";
        static string adminPassword = "password";
        public static void Main(string[] args)
        {
            //create instance of class
            LibraryManagementSystem lbs = new LibraryManagementSystem();

            //string multi-dimensional array to store book details
            string[,,] bookDetails = lbs.TakeBookDetails();

            lbs.CheckChoice(bookDetails);
        }

        //----------------------CHECK CHOICE------------------------
        //method to take choices of users
        public void CheckChoice(string[,,] bookDetails)
        {
            while (true)
            {
                //display choices
                Console.WriteLine("\n1. Display All Books");
                Console.WriteLine("2. Find Book By Author");
                Console.WriteLine("3. Find Book By Title");
                Console.WriteLine("4. Update Status (Admin Only)");
                Console.WriteLine("5. Exit");
                Console.WriteLine("ENTER YOUR CHOICE:");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //check choices using switch case
                switch (choice)
                {
                    //if user enters 1
                    case 1:
                        Console.WriteLine("BOOK DETAILS: ");
                        DisplayAllBooks(bookDetails);
                        break;

                    //if user enters 2
                    case 2:
                        Console.WriteLine("ENTER AUTHOR NAME");
                        string author = Console.ReadLine();
                        SearchBookWithAuthor(bookDetails, author);
                        break;

                    //if user enters 3
                    case 3:
                        Console.WriteLine("ENTER TITLE:");
                        string title = Console.ReadLine();
                        SearchBookWithTitle(bookDetails, title);
                        break;

                    //if user enters 4
                    case 4:
                        if (CheckAdmin())
                        {
                            UpdateStatus(bookDetails);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Cannot Update Status");
                            break;
                        }

                    //if user enters 5
                    case 5:
                        Console.WriteLine("EXIT SUCCESSFUL");
                        return;


                    //if user enters invalid choice
                    default:
                        Console.WriteLine("Invalid Choice. Please enter again");
                        break;
                }

            }
        }

        //------------------------CHECK ADMIN-----------------------
        //method to check admin login credentials
        public static bool CheckAdmin()
        {
            //take username input
            Console.WriteLine("ENTER USERNAME:");
            string userName = Console.ReadLine();

            //take password input
            Console.WriteLine("ENTER PASSWORD");
            string pass = Console.ReadLine();

            return (userName == adminUsername && pass == adminPassword);
        }


        //---------------------TAKE BOOK DETAILS---------------------
        //method to take book details input from the user
        public string[,,] TakeBookDetails()
        {
            //take input for number of books
            Console.WriteLine("ENTER NUMBER OF BOOKS");
            int numberOfBooks = Convert.ToInt32(Console.ReadLine());

            //create a multi-dimensional array to store book details
            string[,,] bookDetails = new string[numberOfBooks, 3, 1];

            //take book details from user
            for (int i = 0; i < numberOfBooks; i++)
            {
                Console.WriteLine($"ENTER DETAILS OF BOOK {i + 1}");

                Console.WriteLine("ENTER TITLE: ");
                bookDetails[i, 0, 0] = Console.ReadLine();

                Console.WriteLine("ENTER AUTHOR: ");
                bookDetails[i, 1, 0] = Console.ReadLine();

                Console.WriteLine("ENTER STATUS: ");
                bookDetails[i, 2, 0] = Console.ReadLine();
            }
            return bookDetails;
        }

        //----------------------PARTIAL SEARCH BY BOOK TITLE----------------------
        //method to search for a book  by title
        public void SearchBookWithTitle(string[,,] bookDetails, string keyword)
        {
            //flag to check if book is found or not
            bool found = false;

            //loop through bookDetails array
            for (int i = 0; i < bookDetails.GetLength(0); i++)
            {
                //if book title contains the keyword
                if (bookDetails[i, 0, 0].ToLower().Contains(keyword.ToLower()))
                {
                    //update flag
                    found = true;

                    //display book
                    Console.WriteLine("\nBOOK FOUND:");

                    DisplayBook(i, bookDetails);

                }
            }
            //if book not found
            if (!found)
            {
                Console.WriteLine("Book not found try again with title or author.");
            }
        }

        //-------------------------PARTIAL SEARCH BY AUTHOR--------------------
        //method to search for a book by author
        public void SearchBookWithAuthor(string[,,] bookDetails, string keyword)
        {
            //flag to check if book is found or not
            bool found = false;

            //loop through bookDetails array
            for (int i = 0; i < bookDetails.GetLength(0); i++)
            {
                //if book author contains the keyword
                if (bookDetails[i, 1, 0].ToLower().Contains(keyword.ToLower()))
                {
                    //update flag
                    found = true;

                    //display book
                    Console.WriteLine("BOOK FOUND:\n");
                    DisplayBook(i, bookDetails);
                }
            }
            //if book not found
            if (!found)
            {
                Console.WriteLine("Book not found try again with author or title.");
            }
        }

        //--------------------------DISPLAY ALL BOOKS-------------------------------
        //method to display all books
        public void DisplayAllBooks(string[,,] bookDetails)
        {
            //loop through bookDetails array and display details
            for (int i = 0; i < bookDetails.GetLength(0); i++)
            {
                Console.WriteLine("\n--------------------------------------------");

                Console.WriteLine("DETAILS OF BOOK: " + (i + 1));

                Console.WriteLine("TITLE: " + bookDetails[i, 0, 0]);

                Console.WriteLine("AUTHOR: " + bookDetails[i, 1, 0]);

                Console.WriteLine("STATUS: " + bookDetails[i, 2, 0]);
            }
        }

        //------------------------DISPLAY BOOK--------------------------------------
        //method to display book
        public void DisplayBook(int i, string[,,] bookDetails)
        {
            Console.WriteLine("TITLE: " + bookDetails[i, 0, 0]);

            Console.WriteLine("AUTHOR: " + bookDetails[i, 1, 0]);

            Console.WriteLine("STATUS: " + bookDetails[i, 2, 0]);

        }

        //---------------------------UPDATE STATUS----------------------------------
        //method to update status of book
        public void UpdateStatus(string[,,] bookDetails)
        {
            //take book number that needs to be updated
            Console.WriteLine("ENTER BOOK NUMBER TO UPDATE:");
            int bookNumber = Convert.ToInt32(Console.ReadLine());

            //check if book number is invalid
            if (bookNumber < 1 || bookNumber > bookDetails.GetLength(0))
            {
                Console.WriteLine("Invalid book number");
                return;
            }

            //take new status
            Console.WriteLine("ENTER NEW STATUS:");
            string newStatus = Console.ReadLine().ToLower();

            //check if entered status is valid or not
            if (newStatus != "available" && newStatus != "checked out")
            {
                Console.WriteLine("Invalid Status");
                return;
            }

            //update book status
            bookDetails[bookNumber - 1, 2, 0] = newStatus;

            Console.WriteLine("STATUS UPDATED");
        }
    }
}
