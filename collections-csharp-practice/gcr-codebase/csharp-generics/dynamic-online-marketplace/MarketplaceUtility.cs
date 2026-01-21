using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.dynamic_online_marketplace
{
    internal class MarketplaceUtility
    {
        //generic method to apply discount
        public static void ApplyDiscount<T>(Product<T> product, double percent) where T : ProductCategory
        {
            product.Price -= product.Price * percent / 100;
        }
    }
}
