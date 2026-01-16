using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.bookshelf
{
    internal class BookNode
    {
        //attributes
        public int bookNumber;

        public string bookTitle;

        public string bookAuthor;

        public bool isAvailable;

        public BookNode Next;

        //constructor
        public BookNode(int bookNumber, string bookTitle, string bookAuthor)
        {
            this.bookNumber=bookNumber;

            this.bookTitle = bookTitle;
            
            this.bookAuthor = bookAuthor;
            
            isAvailable = true;
            
            Next = null;
        }
    }
}
