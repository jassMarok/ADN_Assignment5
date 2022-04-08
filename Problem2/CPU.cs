using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public class CPU
    {
        private static readonly CPU _instance = new CPU();

        private CPU()
        {
        }

        public static CPU GetInstance()
        {
            return _instance;
        }
        public double Speed { get; set; }
        public string Manufacturer { get; set; }
        public string SocketType { get; set; }
        public double CacheSize { get; set; }
        public int NumberOfCores { get; set; }
    }
}
