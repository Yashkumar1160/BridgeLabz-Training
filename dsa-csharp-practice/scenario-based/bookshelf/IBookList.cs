using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.bookshelf
{
    internal interface IBookList
    {
        //method to add book at last in linked list
        void AddBookAtLast(BookNode node);

        //method to search for a book by book number
        BookNode SearchBook(int bookNumber);

        //method to update book status
        void UpdateStatus(int bookNumber,bool status);

        //method to display books
        void DisplayBook();
    }
}
