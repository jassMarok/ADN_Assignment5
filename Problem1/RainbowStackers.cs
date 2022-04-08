using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    /// <summary>
    /// Rainbow Stacker Toy inherited form toy factory
    /// Added three additional properties canBeDissambled,numberOfColors,numberOfRainbows
    /// and Two methods MaxStackHeight ,CanARainbowBeStackedWithSameColor
    /// </summary>
    public class RainbowStackers : ToyFactory
    {
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

        public bool CanBeDissambled { get; set; }

        public int NumberOfColors { get; set; }

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
