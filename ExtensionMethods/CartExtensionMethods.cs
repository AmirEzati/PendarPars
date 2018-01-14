using FuncAndExtensionMethods.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAndExtensionMethods.ExtensionMethods
{
    public static class CartExtensionMethods
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

        public static IEnumerable<Product> FilterByCategory(this IEnumerable<Product> productEnum, string categoryParam)
        {
            double sum = 0;

            foreach (var item in productEnum)
            {
                if (String.Compare(item.Category, categoryParam, ignoreCase: true) == 0)
                {
                    yield return item;
                }
            }

            //return sum;
        }

        public static IEnumerable<Product> FilterByName(this IEnumerable<Product> productEnum, string name)
        {
            double sum = 0;

            foreach (var item in productEnum)
            {
                if (String.Compare(item.Name, name, ignoreCase: true) == 0)
                {
                    yield return item;
                }
            }

            //return sum;
        }


        /// <summary>
        /// A much better way to generalize Filter Method!
        /// </summary>
        /// <param name="products"></param>
        public static IEnumerable<Product> Filter(this IEnumerable<Product> products,Func<Product,bool> selectorParam)
        {
            foreach (var item in products)
            {
                if (selectorParam(item))
                {
                    yield return item;

                }
            }
        }


        public static void IterateByConsole(this IEnumerable<Product> products)
        {
            foreach (var item in products)
            {
                Console.WriteLine("-" + item.Name);
            }
        }
    }
}
