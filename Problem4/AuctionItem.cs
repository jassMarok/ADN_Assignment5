using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Problem4
{
    public class AuctionItem
    {
        /// <summary>
        /// Year of creation
        /// </summary>
        private String _creationYear;

        /// <summary>
        /// Starting price for auction item
        /// </summary>
        private double _startPrice;

        /// <summary>
        /// Name of the item for sale
        /// </summary>
        private String _name;

        /// <summary>
        /// Stack of all bids placed on the auction item
        /// </summary>
        private Stack<Bid> _bidStack;

        /// <summary>
        /// Auction announcer
        /// </summary>
        private Auctioneer _auctioneer;

        /// <summary>
        /// Creates a AuctionItem, that can be sold in auction
        /// </summary>
        /// <param name="name"></param>
        /// <param name="startPrice"></param>
        /// <param name="creationYear"></param>
        /// <param name="_auctioneer"></param>
        public AuctionItem(string name, double startPrice, String creationYear, Auctioneer _auctioneer)
        {
            this._startPrice = startPrice;
            this._creationYear = creationYear;
            this._name = name;
            this._bidStack = new Stack<Bid>();
            this._auctioneer = _auctioneer;

        }

        /// <summary>
        /// Name of auction item
        /// </summary>
        public string Name => _name;

        /// <summary>
        /// Can item be bid on, checks if item has been bid on more than 5 times
        /// </summary>
        /// <returns></returns>
        public bool IsBiddable()
        {
            return  _bidStack.Count < 5; 
        }

        /// <summary>
        /// Updates the auction item bid price, announcer announces the new price to everyone, when an item is sold bidder unsubscribe from the auction
        /// </summary>
        /// <param name="price"></param>
        /// <param name="bidder"></param>

        public void UpdateBid(double price, IAuctionObserver bidder)
        {
            if (price <= CurrentBid())
            {
                _auctioneer.NotifyBidders($"{bidder.Name} has provided a invalid bid amount and will be kicked out");
                bidder.Unsubscribe();
            }
               

            if (!IsBiddable())
                _auctioneer.NotifyBidders($"Bid has ended");

            _bidStack.Push(new Bid(price, bidder.Name));
            _auctioneer.NotifyBidders($"Item:{Name} - {bidder.Name} raised price to {price}");

            if (!IsBiddable())
            {
                _auctioneer.NotifyBidders($"Item:{Name} - SOLD!! to {bidder.Name} for {price}");
                bidder.Unsubscribe();
            }
        }

        /// <summary>
        /// Get the current bid price
        /// </summary>
        /// <returns></returns>
        public double CurrentBid()
        {
            if (_bidStack.Count == 0)
                return _startPrice;
            return _bidStack.Peek().Price;
        }

    }
}
