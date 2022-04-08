using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    /// <summary>
    /// Base abstract calls for all kinds of toys
    /// </summary>
    public abstract class ToyFactory
    {
        /// <summary>
        /// Default constructor will be responsible for setting up Manufacturing date 
        /// for every toy
        /// </summary>
        public ToyFactory(){

            this.YearOfManufacturing = DateTimeOffset.UtcNow.Year;
        }
        /// <summary>
        /// Cost of every toy
        /// </summary>
        public double Cost { get; set; }
        /// <summary>
        /// Descriptions about the toy
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Name of the toy
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// String for Name of Manufacturing company
        /// </summary>
        public string ManufacturingCompany { get; set; }
        /// <summary>
        /// int variable for year of manufacturing
        /// </summary>
        public int YearOfManufacturing { get; set; }
        /// <summary>
        /// int for max age limit of child that should play with this toy
        /// </summary>
        public int MaximumAgeLimit { get; set; }
        /// <summary>
        /// int for min age limit of child that should play with this toy
        /// </summary>
        public int MinimumAgeLimit { get; set; }
        /// <summary>
        /// boolean to check if this toy is a choking hazard
        /// </summary>
        public bool isAnyPartChokingHazard { get; set; }
        /// <summary>
        /// double variable for weight of toy
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// string variable for color of Toy
        /// </summary>
        public string Color { get; set; }   

    }


}
