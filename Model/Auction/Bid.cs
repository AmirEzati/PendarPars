using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAndExtensionMethods.Model.Auction
{
   public class Bid:Base
    {
        public Member Member { get; set; }
        public DateTime DatePlaced { get; set; }
        public decimal BidAmount { get; set; }
    }
}
