using FuncAndExtensionMethods.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAndExtensionMethods.DAL
{
    public class ProductRepository
    {
        public IEnumerable<Product> Get()
        {
            return new List<Product>()
            {
                 new Product() { Name="Vice", Category="Barghi" , Price=15000},
                 new Product() { Name="Pant", Category="Barghi" , Price=10000},
                 new Product() { Name="Mobile", Category="Pooshak" , Price=900},
            };
        }
    }
}
