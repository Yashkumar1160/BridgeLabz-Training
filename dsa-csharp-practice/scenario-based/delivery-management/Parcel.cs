using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.delivery_management
{
    internal class Parcel
    {
        //attributes
        int orderId;
        string customerName;
        bool isDelivered;


        //getter and setter
        public int OrderId
        {
            get; set;
        }

        public string CustomerName
        {
            get; set;
        }

        public bool IsDelivered
        {
            get; set;
        }

        //constructor
        public Parcel(int orderId, string customerName)
        {
            OrderId=orderId;
            CustomerName=customerName;
            IsDelivered=false;
        }


        //override ToString method
        public override string ToString()
        {
            return "OrderId: " + OrderId +
                "\nCustomer Name: " + CustomerName;
        }
    }
}
