using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.flash_dealz
{
    internal interface IProduct
    {
        //method to return partition pivot index 
        int Partition(int low, int high);

        //method to swap products 
        void Swap(int i, int j);

        //method to sort products based on discount using quick sort
        void QuickSort(int low,int high);

        //method to display total products count
        void DisplayProductsCount();

        //method to display all product details
        void DisplayAllProducts();

        //method to call the quick sort method with indices
        void SortProducts();

    }
}
