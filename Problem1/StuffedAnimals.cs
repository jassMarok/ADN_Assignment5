using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    /// <summary>
    /// Class for stuffed animals, inherits base class toy Factory
    /// </summary>
    public class StuffedAnimals : ToyFactory
    {
        /// <summary>
        /// Constructor for Stuffed Animals,
        /// uses three additional unique properties for stuffed animals 
        /// to create a description string
        /// </summary>
        /// <param name="canBeRestuffed"> booolean to check if the toy can be restuffed</param>
        /// <param name="canBeWashed"> boolean to check if toy can be cleaned</param>
        /// <param name="canTheToyBounce"> boolean to check if toy bounces when thrown</param>
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
        /// <summary>
        /// booolean to check if the toy can be restuffed
        /// </summary>
        public bool CanBeRestuffed { get; set; }
        /// <summary>
        /// boolean to check if toy can be cleaned
        /// </summary>
        public bool CanBeWashed { get; set; }
        /// <summary>
        /// boolean to check if toy bounces when thrown
        /// </summary>
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
