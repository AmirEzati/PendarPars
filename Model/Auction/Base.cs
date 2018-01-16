using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAndExtensionMethods.Model.Auction
{
  public abstract  class Base
    {
        public Base()
        {
            Id = new Guid();
        }
        public Guid Id { get; set; }
    }
}
