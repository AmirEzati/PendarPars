using FuncAndExtensionMethods.Model;
using System;
using FuncAndExtensionMethods.ExtensionMethods;

namespace FuncAndExtensionMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            var _productRepository = new DAL.ProductRepository();
            var data = _productRepository.Get();

            foreach (var item in data)
            {
                Console.WriteLine("*All products " + item.Name + " : " + item.Price);
            }

            Console.WriteLine("*Cart products are: ");

            var shoppintCart = new ShoppingCart()
            {
                Products = data,
            };

            Console.WriteLine("*Total is: "+shoppintCart.TotalPrice());

            Console.ReadKey();
        }
    }
}
