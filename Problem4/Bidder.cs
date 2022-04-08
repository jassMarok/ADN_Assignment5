using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4
{
    public class Bidder: IAuctionObserver
    {
        /// <summary>
        /// Increment amount for new bid
        /// </summary>
        private static readonly double _increaseAmount = 10.00;

        /// <summary>
        /// Reference for unsubscribing
        /// </summary>
        private IDisposable unsubscriber;

        /// <summary>
        /// Auction item for bid
        /// </summary>
        private AuctionItem _item;

        /// <summary>
        /// Name of bidder
        /// </summary>
        private String _name;

        /// <summary>
        /// Budget of bidder
        /// </summary>
        private double _budget;

        /// <summary>
        /// Stack of all messages being received
        /// </summary>
        private Stack<String> _receivedMessages;
 
        /// <summary>
        /// Name of Bidder
        /// </summary>
        public string Name => _name;

        /// <summary>
        /// Creates a bidder that can subscribe to auction announcements
        /// </summary>
        /// <param name="name"></param>
        /// <param name="item"></param>
        /// <param name="budget"></param>
        public Bidder(string name, AuctionItem item, double budget)
        {
            _item = item;
            _name = name;
            _budget = budget;
            _receivedMessages = new Stack<string>();
        }

        /// <summary>
        /// Retrieve latest message from auction announcements
        /// </summary>
        /// <returns>last message received by bidder</returns>
        public String GetLatestMessage()
        {
            return _receivedMessages.Peek();
        }

        /// <summary>
        /// Bid on item, increases the bid amount by _increaseAmount
        /// If item current bid is greater than budget unsubscribe
        /// </summary>
        public void GiveNewPrice()
        {
            if (_budget > _item.CurrentBid() + _increaseAmount && _item.IsBiddable())
            {
                _item.UpdateBid(_item.CurrentBid() + _increaseAmount, this);
            }
            else
            {
                //Cannot buy this item anymore unsubscribe
                Unsubscribe();
            }
        }

        /// <summary>
        /// Pushes incoming message to local message stack
        /// </summary>
        /// <param name="announcement"></param>
        public void Update(string announcement)
        {
            _receivedMessages.Push($"{announcement}, received by: {_name}");
        }

        /// <summary>
        /// Subscribe to an auction
        /// </summary>
        /// <param name="provider"></param>
        public virtual void Subscribe(Auctioneer provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        /// <summary>
        /// Unsubscribe from auction
        /// </summary>
        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }

       
    }
}
