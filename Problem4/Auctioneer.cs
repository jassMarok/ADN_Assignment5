using System;
using System.Collections.Generic;

namespace Problem4
{
    public class Auctioneer
    {
        /// <summary>
        /// All bidders involved in auction
        /// </summary>
        private List<IAuctionObserver> _observers;

        public Auctioneer()
        {
            this._observers = new List<IAuctionObserver>();
        }

        /// <summary>
        /// Subscribes an bidder to the auction
        /// </summary>
        /// <param name="bidder"></param>
        /// <returns></returns>
        public IDisposable Subscribe(Bidder bidder)
        {
            _observers.Add(bidder);
            NotifyBidders($"Bidder joined: {bidder.Name}, Total Bidders: {_observers.Count}");
            return new Unsubscriber(_observers, bidder);
        }

        /// <summary>
        /// Notifies all bidders with an announcement
        /// </summary>
        /// <param name="notification"></param>
        public void NotifyBidders(string notification)
        {
            this._observers.ForEach(bidder => bidder.Update(notification));
        }

        /// <summary>
        /// Class to handle unsubscribe from auction
        /// </summary>
        private class Unsubscriber: IDisposable
        {
            private List<IAuctionObserver> _observers;
            private IAuctionObserver _observer;

            public Unsubscriber(List<IAuctionObserver> observers, IAuctionObserver observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
    }
}
