using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4
{
    public interface IAuctionObserver
    {
        string Name
        {
            get;
        }
        public void Update(string announcement);
        public void Unsubscribe();
        public void Subscribe(Auctioneer provider);

    }
}
