using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.dynamic_online_marketplace
{
    internal abstract class ProductCategory
    {
        //variable to store product category
        string categoryName;

        //getter and setter
        public string CategoryName { get; set; }

        //constructor
        public ProductCategory(string categoryName)
        {
            CategoryName = categoryName;
        }
    }
}
