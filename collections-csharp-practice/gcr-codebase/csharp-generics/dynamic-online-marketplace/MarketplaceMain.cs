using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.dynamic_online_marketplace
{
    internal class MarketplaceMain
    {
        public static void Main(string[] args)
        {
            //take product name
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            //take price
            Console.Write("Enter price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            //take discount percent
            Console.Write("Enter discount %: ");
            double discount = Convert.ToDouble(Console.ReadLine());

            //generic storage
            Product<BookCategory> product = new Product<BookCategory>(name, price);

            //apply discount
            MarketplaceUtility.ApplyDiscount(product, discount);

            //display product info
            product.Display();
        }
    }
}
