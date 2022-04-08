using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    /// <summary>
    ///  Class for Cars, inherits base class toy Factory
    /// </summary>
    public class Cars : ToyFactory
    {
        /// <summary>
        /// Constructor for Cars uses three additional unique properties  
        /// to create a description string.
        /// </summary>
        /// <param name="canWheelsRotate">boolean to check is wheels can rotate</param>
        /// <param name="numberOfDoors"> variable for number of dogs in a car </param>
        /// <param name="canWindowsOpen"> variable to check if windows can open </param>
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

        /// <summary>
        /// boolean to check is wheels can rotate
        /// </summary>
        public bool CanWheelsRotate { get; set; }
        /// <summary>
        /// variable for number of dogs
        /// </summary>
        public int NumberOfDoors { get; set; }
        /// <summary>
        /// variable to check if windows can open
        /// </summary>
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

        /// <summary>
        /// method to check if car can be colored
        /// </summary>
        /// <returns></returns>
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
