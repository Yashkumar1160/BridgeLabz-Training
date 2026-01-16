using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.bookshelf
{
    internal interface IBookShelf
    {
        //method to add book for a specific genre
        void AddBook(string genre, int bookNumber, string bookTitle, string bookAuthor);

        //method to check if a genre exists in bookshelf dictionary
        bool CheckGenre(string genre);

        //method to add genre
        void AddGenre(string genre);

        //method to remove a genre
        void RemoveGenre(string genre);

        //method to borrow a book
        void BorrowBook(int bookNumber);

        //method to return a book
        void ReturnBook(int bookNumber);

        //method to check if a book already exists
        bool CheckBookNumber(int bookNumber);

        //method to display all books by genre
        void DisplayBooksByGenre();
    }
}
