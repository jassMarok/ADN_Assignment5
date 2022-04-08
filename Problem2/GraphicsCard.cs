using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public class GraphicsCard
    {

        private static readonly GraphicsCard _instance = new GraphicsCard();

        private GraphicsCard()
        {
        }

        public static GraphicsCard GetInstance()
        {
            return _instance;
        }
        public int FanCount { get; set; }
        public double Speed { get; set; }
        public int VideoMemory { get; set; }
        public int NumberOfCudaCores { get; set; }

    }
}
