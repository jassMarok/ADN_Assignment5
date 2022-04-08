using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    /// <summary>
    /// Class Rainbow Stacker Toy inherited form toy factory
    /// Added three additional properties canBeDissambled,numberOfColors,numberOfRainbows
    /// and Two methods MaxStackHeight ,CanARainbowBeStackedWithSameColor
    /// </summary>
    public class RainbowStackers : ToyFactory
    {
        /// <summary>
        /// constructor to Rainbows stacker,
        /// uses three additional unique properties 
        /// to create a description string
        /// </summary>
        /// <param name="canBeDissambled">boolean to check if rainbows can be disassembld </param>
        /// <param name="numberOfColors">variable for different kind of colors available</param>
        /// <param name="numberOfRainbows"> int variable to count max no. of rainbows that can be created</param>
        public RainbowStackers( bool canBeDissambled, int numberOfColors, int numberOfRainbows)
        {
            this.CanBeDissambled = canBeDissambled;
            this.NumberOfRainbows = numberOfRainbows;
            this.NumberOfColors = numberOfColors;

            Cost = 20.00;
            Description = "This Toy can be dissambled : " +
                "" + CanBeDissambled + "\nNumber of different Colors : "+
                NumberOfColors + "\nNumebr of Rainbows that can be made : " + NumberOfRainbows;
            Name = "7 Colors";
            ManufacturingCompany = "MohawkCollege";
            MinimumAgeLimit = 3;
            MaximumAgeLimit = 10;
            isAnyPartChokingHazard = true;
            Weight = 30;
            Color = "Green";

        }
        /// <summary>
        /// boolean to check if rainbows can be disassembld 
        /// </summary>
        public bool CanBeDissambled { get; set; }
        /// <summary>
        /// variable for different kind of colors available
        /// </summary>
        public int NumberOfColors { get; set; }
        /// <summary>
        /// int variable to count max no. of rainbows that can be created
        /// </summary>
        public int NumberOfRainbows { get; set; }

        /// <summary>
        /// method ot get the max height of the stack that can be created 
        /// </summary>
        /// <returns></returns>
        public double MaxStackHeight() {

            return NumberOfColors*NumberOfRainbows;
        }

        /// <summary>
        /// this method will return true if one stack of rainbow can have same color
        /// </summary>
        /// <returns></returns>
        public bool CanARainbowBeStackedWithSameColor()
        {
            if (CanBeDissambled)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
