using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.book_buddy
{
    internal class Book
    {
        //variable to store title
        private string title;

        //variable to store author name
        private string author;

        //getter and setter for title
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        //getter and setter for author 
        public string Author
        {
            get { return author; }
            set { author = value; }
        }


        //constructor
        public Book(string title, string author)
        {
            Title= title;
             Author= author;
        }


    }
}
