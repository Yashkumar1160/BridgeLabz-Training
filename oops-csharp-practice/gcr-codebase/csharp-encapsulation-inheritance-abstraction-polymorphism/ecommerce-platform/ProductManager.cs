using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.ecommerce_platform
{
    internal class ProductManager
    {
        //array to store products
        Product[] products = new Product[100];

        //variable to store total products count
        int count = 0;

        //method to add  product
        public void AddProduct(Product product)
        {
            products[count] = product;
            count++;
        }

        //method to display all products
        public void DisplayAllProducts()
        {
            for (int i = 0; i < count; i++)
            {
                products[i].DisplayDetails();

                double tax = 0;

                // check if product is taxable
                if (products[i] is ITaxable taxable)
                {
                    tax = taxable.CalculateTax();
                    Console.WriteLine("TAX: " + tax);
                    Console.WriteLine(taxable.GetTaxDetails());
                }
                else
                {
                    Console.WriteLine("NO TAX APPLIED");
                }

                double discount = products[i].CalculateDiscount();
                Console.WriteLine("DISCOUNT: " + discount);

                double finalPrice = products[i].Price + tax - discount;
                Console.WriteLine("FINAL PRICE: " + finalPrice);
            }
        }
    }
}
