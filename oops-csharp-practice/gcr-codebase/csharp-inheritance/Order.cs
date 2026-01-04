using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    //base class Order
    internal class Order
    {
        //protected variables
        protected int orderId;

        protected string orderDate;

        //parameterized constructor
        public Order(int id, string orderDate)
        {
            this.orderId = id;
            this.orderDate = orderDate;
        }

        //method to display order status
        public virtual string GetOrderStatus()
        {
            return "ORDER PLACED SUCCESSFULLY";
        }
    }

    //derived class ShippedOrder
    class ShippedOrder : Order
    {
        //protected variable
        protected string trackingNumber;

        //parameterized constructor
        public ShippedOrder(int id, string orderDate, string track) : base(id, orderDate)
        {
            this.trackingNumber = track;
        }

        //override GetOrderStatus method
        public override string GetOrderStatus()
        {
            return "ORDER SHIPPED";
        }
    }

    //derived class DeliveredOrder
    class DeliveredOrder : ShippedOrder
    {
        //private variable
        string deliveryDate;

        //parameterized constructor
        public DeliveredOrder(int id, string orderDate, string track, string deliveryDate) : base(id, orderDate, track)
        {
            this.deliveryDate = deliveryDate;
        }

        //override GetOrderStatus method
        public override string GetOrderStatus()
        {
            return "ORDER DELIVERED";
        }
    }

    //class containing Main method
    class Program
    {
        public static void Main(string[] args)
        {
            //call TakeInputs method
            TakeInputs();
        }


        //method to take user inputs
        public static void TakeInputs()
        {
            //take order id input
            Console.Write("ENTER ORDER ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            //take order date input
            Console.Write("ENTER ORDER DATE: ");
            string orderDate = Console.ReadLine();

            //take tracking number input
            Console.Write("ENTER TRACKING NUMBER: ");
            string trackingNumber = Console.ReadLine();

            //take delivery date input
            Console.Write("ENTER DELIVERY DATE: ");
            string deliveryDate = Console.ReadLine();

            //create object of DeliveredOrder class
            Order order = new DeliveredOrder(id, orderDate, trackingNumber, deliveryDate);

            //call GetOrderStatus to display order details
            Console.WriteLine("\nORDER SUMMARY: " + order.GetOrderStatus());
        }
    }
}
