using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public class Motherboard
    {
        private static readonly Motherboard _instance = new Motherboard();

        private Motherboard()
        {
        }

        public static Motherboard GetInstance()
        {
            return _instance;
        }
        public int NumberOfMemorySlots { get; set; }
        public int PowerConsumption { get; set; }
        public int NumberOfPCISlots { get; set; }
        public string FormFactor { get; set; }
        public int HardDriveLimit { get; set; }
        public CPU CPU { get; set; }
        public Memory Memory { get; set; }
        public GraphicsCard GraphicsCard { get; set; }
    }
}
