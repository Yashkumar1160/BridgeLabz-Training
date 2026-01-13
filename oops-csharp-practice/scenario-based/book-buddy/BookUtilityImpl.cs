    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.book_buddy
{
    internal class BookUtilityImpl : IBook
    {
        //array to store books
        string[] books = new string[100];

        //variable to store total books count
        int totalBooks = 0;


        //method to search for a book by title 
        public void SearchByTitle(string title)
        {
            //if no book is added
            if (totalBooks == 0)
            {
                Console.WriteLine("NO BOOKS ADDED YET");
                return;
            }

            //flag to check if book is present 
            bool flag = false;

            //loop through array to find book
            for (int i = 0; i < totalBooks; i++)
            {
                //split the title
                string bookTitle=books[i].Split("-")[0];
             
                //check if both the title matches
                if (bookTitle.ToLower().Contains(title.ToLower()))
                {
                    //update flag
                    flag = true;

                    //display book details
                    DisplayBook(books[i]);
                }
            }


            //if book not found
            if (!flag)
            {
                Console.WriteLine("BOOK NOT FOUND. TRY SEARCH BY AUTHOR");
            }
        }

        
        //method to search for a book by author
        public void SearchByAuthor(string author)
        {
            //if no book is added
            if (totalBooks == 0)
            {
                Console.WriteLine("NO BOOKS ADDED YET");
                return;
            }


            //flag to check if book is present
            bool flag = false;


            //loop through array to find book 
            for (int i = 0; i < totalBooks; i++)
            {
                //split the book author
                string bookAuthor = books[i].Split("-")[1];


                //check if both author matches
                if (bookAuthor.ToLower().Contains(author.ToLower()))
                {
                    //update flag
                    flag = true;
                    
                    //display book details
                    DisplayBook(books[i]);  
                }
            }

            //if book not found
            if (!flag)
            {
                Console.WriteLine("BOOK NOT FOUND. TRY TO SEARCH BY TITLE");
            }
        }


        //method to add book to array
        public void AddBook(string title, string author)
        {
            //check if array is full
            if (totalBooks >= books.Length){
                Console.WriteLine("BOOKSHELF FULL");
                return;
            }

            string book = title + "-" + author;

            books[totalBooks] = book;
            
            totalBooks++;
        }


        //method to sort book alphabetically
        public void SortBooksAlphabetically()
        {
            //if no book is added
            if (totalBooks == 0)
            {
                Console.WriteLine("NO BOOKS ADDED YET");
                return;
            }


            //loop to sort books
            for (int i = 0;i <totalBooks-1;i++)
            {
                for(int j= 0;j < totalBooks;j++)
                {
                    //take titles
                    string title1=books[i].Split("-")[0].ToLower();
                    string title2 = books[j].Split("-")[0].ToLower();

                    //find greater and swap
                    if (string.Compare(title1,title2)>0)
                    {
                        string temp = books[i];
                        books[i]=books[j];
                        books[j]=temp;
                    }
                }
            }
        }


        //method to display all books
        public void DisplayAllBooks()
        {
            if (totalBooks == 0)
            {
                Console.WriteLine("NO BOOKS ADDED YET");
                return;
            }

            Console.WriteLine("ALL BOOK DETAILS: ");

            for(int i = 0;i<totalBooks; i++)
            {
                DisplayBook(books[i]);
            }
        }

        //method to display details of a book
        public static void DisplayBook(string book)
        {

            string title = book.Split("-")[0];
            string author = book.Split('-')[1];

            Console.WriteLine("\nBOOK TITLE: " + title);
            Console.WriteLine("BOOK AUTHOR: " + author);
        }
    }
}
