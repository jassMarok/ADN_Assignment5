using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public abstract class ToyFactory
    {
        public ToyFactory(){

            this.YearOfManufacturing = DateTimeOffset.UtcNow.Year;
        }
        public double Cost { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string ManufacturingCompany { get; set; }

        public int YearOfManufacturing { get; set; }

        public int MaximumAgeLimit { get; set; }

        public int MinimumAgeLimit { get; set; }

        public bool isAnyPartChokingHazard { get; set; }

        public double Weight { get; set; }

        public string Color { get; set; }   


    }


}
