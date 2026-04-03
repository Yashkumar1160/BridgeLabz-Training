using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    //super class HybridPerson
    internal class HybridPerson
    {
        //protected variables
        protected string name;

        protected int id;

        //parameterized constructor
        public HybridPerson(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }

    //interface Worker
    interface Worker
    {
        //PerformDuties method
        void PerformDuties();
    }

    //derived class Chef implementing Worker interface
    class Chef : HybridPerson, Worker
    {
        //parameterized constructor
        public Chef(string name, int id) : base(name, id) { }

        //implementation of PerformDuties method
        public void PerformDuties()
        {
            Console.WriteLine("CHEF COOKS FOOD");
        }
    }

    //derived class Waiter implementing Worker interface
    class Waiter : HybridPerson, Worker
    {
        //parameterized constructor
        public Waiter(string name, int id) : base(name, id) { }

        //implementation of PerformDuties method
        public void PerformDuties()
        {
            Console.WriteLine("WAITER SERVES FOOD");
        }
    }

    //class containing Main method
    class Program
    {
        public static void Main(string[] args)
        {
            //call the TakeInputs method
            TakeInputs();
        }

        //method to take user inputs
        public static void TakeInputs()
        {
            //take chef name input
            Console.Write("ENTER CHEF NAME: ");
            string chefName = Console.ReadLine();

            //take chef id input
            Console.Write("ENTER CHEF ID: ");
            int chefId = Convert.ToInt32(Console.ReadLine());

            //create object using Worker interface reference
            Worker chef = new Chef(chefName, chefId);

            //call PerformDuties method 
            Console.WriteLine();
            chef.PerformDuties();

            //take waiter name input
            Console.Write("\nENTER WAITER NAME: ");
            string waiterName = Console.ReadLine();

            //take waiter id input
            Console.Write("ENTER WAITER ID: ");
            int waiterId = Convert.ToInt32(Console.ReadLine());

            //create object using Worker interface reference
            Worker waiter = new Waiter(waiterName, waiterId);

            //call PerformDuties method
            Console.WriteLine();
            waiter.PerformDuties();
        }
    }

}
