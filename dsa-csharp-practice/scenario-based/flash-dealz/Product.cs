using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.flash_dealz
{
    internal class Product
    {
        //attributes
        private int productId;
        private string productName;
        private double productDiscount;
        private double productPrice;
        private int quantity;

        //getters and setters
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductDiscount { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        //constructor
        public Product(int productId,string productName,double productDiscount,double productPrice,int quantity)
        {
            ProductId = productId;
            ProductName = productName;
            ProductDiscount= productDiscount;
            ProductPrice= productPrice;
            ProductQuantity= quantity;
        }


        //override ToString method
        public override string ToString()
        {
            return "\nProduct Name: " + ProductName +
                "\nProduct Id: "+ProductId+
                "\nPrice: " + ProductPrice +
                "\nDiscount: " + ProductDiscount +
                "\nQuantity: " + ProductQuantity;
        }
    }
}
