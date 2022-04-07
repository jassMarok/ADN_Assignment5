using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public class StuffedAnimals : ToyFactory
    {
        public StuffedAnimals(bool canBeRestuffed, bool canBeWashed, bool canTheToyBounce)
        {
            this.CanBeWashed = canBeWashed;
            this.CanBeRestuffed = canBeRestuffed;
            this.CanTheToyBounce = canTheToyBounce;

            Cost = 30.00;
            Description = "This Toy can be washed : " +
                "" + CanBeWashed + "\nCan It be Restuffed : " +
                CanBeRestuffed + "\nCan The Toy bounce : " + CanTheToyBounce;
            Name = "Pet Animals";
            ManufacturingCompany = "MohawkCollege";
            MinimumAgeLimit = 2;
            MaximumAgeLimit = 10;
            isAnyPartChokingHazard = false;
            Weight = 15;
            Color = "Grey";

        }

        public bool CanBeRestuffed { get; set; }

        public bool CanBeWashed { get; set; }

        public bool CanTheToyBounce { get; set; }

        /// <summary>
        /// Method that returns amout for water needed for refilling animal
        /// </summary>
        /// <returns></returns>
        public double AmountOfWaterForRefill() {

            return Weight * 1.5;
        }

        /// <summary>
        /// Maximum Height the toy can bounce When thrown
        /// </summary>
        /// <returns></returns>
        public double MaxBounceHeight() {

            return Weight / 0.2;
        
        }



    }
}
