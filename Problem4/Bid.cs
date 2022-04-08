using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4
{
    internal class Bid
    {
        /// <summary>
        /// Creates a bid, with a price and bidder name
        /// </summary>
        /// <param name="price"></param>
        /// <param name="bidderName"></param>
        public Bid(double price, string bidderName)
        {
            Price = price;
            BidderName = bidderName;
        }

        /// <summary>
        /// Price of the bid
        /// </summary>
        public double Price { get; }

        /// <summary>
        /// Name of bidder
        /// </summary>
        public string BidderName { get; }
    }
}
