using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Problem2
{
    public class HardDrive
    {

        private static readonly HardDrive _instance = new HardDrive();

        private HardDrive()
        {
        }

        public static HardDrive GetInstance()
        {
            return _instance;
        }
        public double Capacity { get; set; }
        public string Type { get; set; }
        public int ReadSpeed { get; set; }
        public int WriteSpeed { get; set; }
        
    }
}
