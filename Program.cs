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

            Console.WriteLine("*Total is: " + shoppintCart.TotalPrice());

            var shoppintCart2 = new ShoppingCartI()
            {
                Products = data,
            };

            Console.WriteLine("*Total ShoppingCartI is: " + shoppintCart2.TotalPrice());



            shoppintCart2.FilterByCategory("Barghi").IterateByConsole();
            shoppintCart2.FilterByName("pant").IterateByConsole();

            Console.WriteLine("***************************Using Func Delegates**********************************");
            //First way
            Func<Product, bool> selectorFunc1 =
                delegate (Product prod)
            {
                return prod.Category == "Barghi";
            };

            Func<Product, bool> selectorFuncByCategory = prod => prod.Category == "Barghi";
            shoppintCart2.Filter(selectorFuncByCategory).IterateByConsole();

            Func<Product, bool> selectorFuncByName = prod => prod.Name == "Pant";
            shoppintCart2.Filter(selectorFuncByName).IterateByConsole();

            //The best way
            shoppintCart2.Filter(prod => String.Compare(prod.Name, "pant", ignoreCase: true) == 0).IterateByConsole();
            shoppintCart2.Filter(prod => prod.Price < 1000).IterateByConsole();


            Console.ReadKey();
        }
    }
}
