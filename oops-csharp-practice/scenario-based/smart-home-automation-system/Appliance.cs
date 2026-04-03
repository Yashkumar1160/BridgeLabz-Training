using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system
{
    internal abstract class Appliance
    {
        //variable to store brand name
        protected string brandName;

        //variable to store model
        protected int modelNumber;

        //variable to check if appliance has remote
        protected bool hasRemote;

        //variable to store warranty
        protected int warranty;

        //variable to store price
        protected double price;


        //getter and setter for brandName
        public string BrandName
        {
            get { return brandName; } 
            set { brandName = value; }
        }

        //getter and setter for model
        public int ModelNumber
        {
            get { return modelNumber; }
            set { modelNumber = value; }
        }

        //getter and setter for hasRemote
        public bool HasRemote
        {
            get { return hasRemote; }
            set { hasRemote = value; }
        }

        //getter and setter for warranty
        public int Warranty
        {
            get { return warranty;}
            set { warranty = value; }
        }

        //getter and setter for price
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        //constructor
        public Appliance(string name, int modelNumber, bool remote, int warranty, double price)
        {
            BrandName = name;

            ModelNumber = modelNumber;

            HasRemote = remote;

            Warranty = warranty;

            Price = price;
        }

        //override to string method
        public override string ToString()
        {
            return "\nBRAND NAME: " + BrandName +
                "\nMODEL NUMBER: " + ModelNumber +
                "\nHAS REMOTE: " + HasRemote +
                "\nWARRANTY PERIOD: " + Warranty +
                "\nPRICE: " + Price;
        }
    }
}
