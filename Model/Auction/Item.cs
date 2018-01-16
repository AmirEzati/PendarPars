using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncAndExtensionMethods.Model.Auction
{
    public class Item : Base
    {
        public Item()
        {
            Bids = new List<Bid>();
        }
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime AuctionEndDate { get; set; }
        public IList<Bid> Bids { get; set; }

        public void AddBid(Member member, decimal amount)
        {

            if (Bids.Any(c=>c.BidAmount>amount))
            {
                throw new InvalidOperationException();
            }

            Bids.Add(new Bid()
            {
                BidAmount = amount,
                Member = member,
            });
        }
    }
}
