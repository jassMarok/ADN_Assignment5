using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{

    public class DollHouses : ToyFactory
    {
        /// <summary>
        /// Coonstructor for Dool House
        /// </summary>
        /// <param name="canRearrangeRoomsAndBuiltToys"></param>
        /// <param name="numberOfRooms"></param>
        /// <param name="canWindowsOpen"></param>
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

        public bool CanRearrangeRoomsAndBuiltToys { get; set; }

        public int NumberOfRooms { get; set; }

        public bool CanWindowsOpen { get; set; }

        /// <summary>
        /// method cehck if the rooms and toys can be moved inside
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
