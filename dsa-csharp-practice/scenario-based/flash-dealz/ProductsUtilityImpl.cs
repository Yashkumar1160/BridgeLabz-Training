using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.flash_dealz
{
    internal class ProductsUtilityImpl : IProduct 
    {
        //array to store products
        Product[]products=new Product[1000];


        //variable to store total products count
        int totalProducts = 0;


        //method to generate random data 
        public void GenerateRandomData()
        {
            //create object of Random class
            Random random = new Random();

            //loop to take product data
            for(int i = 0; i < products.Length; i++)
            {
                int productId = i + 1;
                string productName = $"Product {i+1}";
                double productPrice = Math.Round(random.NextDouble() * 10000 + 100,2);
                double productDiscount = Math.Round(random.NextDouble() * 60,2);
                int productQuantity = random.Next(1,200);

                //create object of Product class
                Product product = new Product(productId, productName, productDiscount, productPrice, productQuantity);

                //add product to array
                products[totalProducts++] = product;
            }
        }


        //method to sort products based on discount using quick sort
        public void QuickSort(int low,int high)
        {

            if(low < high)
            {
                //store partition index of pivot
                int pi=Partition(low,high);

                //recursive calls
                QuickSort(low, pi - 1);
                QuickSort(pi + 1, high);
            }
        }


        //method for partition
        public int Partition(int low,int high)
        {
            //choose pivot
            int pivot = high;

            int i = low - 1;

            for(int j = low; j <= high - 1; j++)
            {
                if (products[j].ProductDiscount > products[pivot].ProductDiscount)
                {
                    i++;
                    Swap(i, j);
                }
            }

            //swap 
            Swap(i + 1,high);
            return i + 1;
        }


        //method to swap products
        public void Swap(int i, int j)
        {
            Product temp = products[i];
            products[i] = products[j];
            products[j] = temp;
        }


        //method to sort products 
        public void SortProducts()
        {
            //call quick sort method
            QuickSort(0, totalProducts - 1);
            Console.WriteLine("\nProducts Sorted Successfully");
        }

        
        //method to display total products count    
        public void DisplayProductsCount()
        {
            Console.WriteLine("\nTotal Products: " + totalProducts);
        }


        //method to display all products 
        public void DisplayAllProducts()
        {
            for(int i = 0; i < totalProducts; i++)
            {
                Console.WriteLine(products[i]);
            }
        }
    }
}
