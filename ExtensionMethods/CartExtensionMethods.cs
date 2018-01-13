using FuncAndExtensionMethods.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAndExtensionMethods.ExtensionMethods
{
  public static  class CartExtensionMethods
    {
        public static double TotalPrice(this ShoppingCart cartItem)
        {
            double sum = 0;

            foreach (var item in cartItem.Products)
            {
                sum += item.Price;
            }

            return sum;
        }

        public static double TotalPrice(this IEnumerable<Product> productEnum)
        {
            double sum = 0;

            foreach (var item in productEnum)
            {
                sum += item.Price;
            }

            return sum;
        }
    }
}
