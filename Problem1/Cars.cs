using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public class Cars : ToyFactory
    {
        public Cars(bool canWheelsRotate, int numberOfDoors, bool canWindowsOpen) {

            this.CanWheelsRotate = canWheelsRotate;
            this.NumberOfDoors = numberOfDoors;
            this.CanWindowsOpen = canWindowsOpen;

            Cost = 10.00;
            Description = "Are Wheels rotatble? : " +
                "" + canWheelsRotate + "\nNo.ofDoors : " +
                numberOfDoors + "\nCan the Widows of Car open : " + canWindowsOpen ;

            Name = "Hot Wheels";
            ManufacturingCompany = "Mohawk College";
            MinimumAgeLimit = 5;
            MaximumAgeLimit = 12;
            isAnyPartChokingHazard = true;
            Weight = 10;
            Color = "Red";

        }

        public bool CanWheelsRotate { get; set; }

        public int NumberOfDoors { get; set; }

        public bool CanWindowsOpen { get; set; }

        /// <summary>
        /// Method returns the max speed car can drive if wheels are rotatable
        /// </summary>
        /// <returns></returns>
        public double MaxCarSpeed() {
            if (CanWheelsRotate)
            {
                return 20 / Weight;
            }

            else {
                return 0;
            }
        }

        public bool CanCarColorBeChanged() {
            if (CanWindowsOpen)
            {
                return false;
            }
            else {

                return true;
            }
        
        }


    }
}
