using System;
using System.Collections;
using System.Collections.Generic;

namespace FuncAndExtensionMethods.Model
{
    public class ShoppingCartI:IEnumerable<Product> 
    {
        public IEnumerable<Product> Products { get; set; }

        public IEnumerator<Product> GetEnumerator()
        {
            return Products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
