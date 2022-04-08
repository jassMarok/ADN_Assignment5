using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    /// <summary>
    /// Class for Doll Houses, inherits base class toy Factory
    /// </summary>
    public class DollHouses : ToyFactory
    {
        /// <summary>
        /// Constructor for Dool House uses three additional unique properties  
        /// to create a description string
        /// </summary>
        /// <param name="canRearrangeRoomsAndBuiltToys"> boolean to chekc is rooms and otehr toys are movable</param>
        /// <param name="numberOfRooms"> int variable to count no.of rooms </param>
        /// <param name="canWindowsOpen"> boolean to check if windows for all the rooms open </param>
        public DollHouses(bool canRearrangeRoomsAndBuiltToys, int numberOfRooms, bool canWindowsOpen)
        {
            this.CanWindowsOpen = canWindowsOpen;
            this.CanRearrangeRoomsAndBuiltToys = canRearrangeRoomsAndBuiltToys;
            this.NumberOfRooms = numberOfRooms;

            Cost = 40.00;
            Description = "Can the Widows of Doll House open : " +
                "" + CanWindowsOpen + "\nCan rooms be rearranged : " +
                CanRearrangeRoomsAndBuiltToys + "\nTotal number of rooms : " + NumberOfRooms;
            Name = "7 Colors"; ;
            Name = "Play Houses";
            ManufacturingCompany = "MohawkCollege";
            MinimumAgeLimit = 5;
            MaximumAgeLimit = 12;
            isAnyPartChokingHazard = true;
            Weight = 70;
            Color = "Pink";

        }
        /// <summary>
        /// boolean to chekc is rooms and otehr toys are movable
        /// </summary>
        public bool CanRearrangeRoomsAndBuiltToys { get; set; }
        /// <summary>
        /// int variable to count no.of rooms
        /// </summary>
        public int NumberOfRooms { get; set; }
        /// <summary>
        /// boolean to check if windows for all the rooms open
        /// </summary>
        public bool CanWindowsOpen { get; set; }

        /// <summary>
        /// method check if the rooms and toys can be moved inside
        /// if yes will return True as dolls can be moved to sleeping rooms
        /// else falls
        /// </summary>
        /// <returns>Boolean</returns>
        public bool  CanDollsbePutToSleep() {
            if (CanRearrangeRoomsAndBuiltToys)
            {

                return true;

            }
            else { 
                return false;
            }
        
        }
        /// <summary>
        /// Method to check is dool house is too heavy for dolls to be moved around
        /// </summary>
        /// <returns>Boolean</returns>
        public bool CanKidsMoveDollHouse() {

            if (Weight < 100)
            {
                return true;

            }
            else { 
            
                return false ;
            }
        
        }

    }
}
