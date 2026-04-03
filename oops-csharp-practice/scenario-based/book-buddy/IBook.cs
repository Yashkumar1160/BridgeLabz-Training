using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.book_buddy
{
    internal interface IBook
    {
        //method to add book
        void AddBook(string title,string author);

        //method to sort books alphabetically
        void SortBooksAlphabetically();

        //method to search for a book by author
        void SearchByAuthor(string author);

        //method to search for a book by title
        void SearchByTitle(string title);
    }
}
