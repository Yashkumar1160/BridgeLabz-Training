using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.library_management_system
{
    internal abstract class LibraryItem
    {

        //protected variables
        protected int itemId;

        protected string title;
        
        protected string author;

        //private variables
        private string borrowerName;
        
        private bool isReserved;

        //getter and setter for itemId
        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

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

        //parameterized constructor
        public LibraryItem(int id, string title, string author)
        {
            itemId = id;
            this.title = title;
            this.author = author;
            isReserved = false;
        }

        //method to set reservation
        protected void SetReservation(string name)
        {
            borrowerName = name;
            isReserved = true;
        }

        //method to check if item is reserved
        protected bool IsReserved()
        {
            return isReserved;
        }

        //abstract method to get loan duration
        public abstract int GetLoanDuration();

        //concrete method to display item details
        public void GetItemDetails()
        {
            Console.WriteLine("\nITEM ID: " + ItemId);

            Console.WriteLine("TITLE: " + Title);
            
            Console.WriteLine("AUTHOR: " + Author);
        }
    }
}
