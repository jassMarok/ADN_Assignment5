using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public class Memory
    {
       
        private static readonly Memory _instance = new Memory();

        private Memory()
        {
        }

        public static Memory GetInstance()
        {
            return _instance;
        }
        public double ReadSpeed { get; set; }
        public string WriteSpeed { get; set; }
        public string Type { get; set; }
        public double AmountInGB { get; set; }
        
    }
   
}
