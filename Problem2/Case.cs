using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    public class Case
    {

        private static readonly Case _instance = new Case();

        private Case()
        {
        }

        public static Case GetInstance()
        {
            return _instance;
        }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public int NumberOfFans { get; set; }
        public int NumberOfVents { get; set; }

    }
}
