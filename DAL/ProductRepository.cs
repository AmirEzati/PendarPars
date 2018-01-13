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
                 new Product() { Name="Vice" , Price=15000},
                 new Product() { Name="Pant" , Price=10000},
                 new Product() { Name="Mobile" , Price=25000},
            };
        }
    }
}
