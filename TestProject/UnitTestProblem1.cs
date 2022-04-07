using System;
using Xunit;
using Problem1;

namespace TestProject
{
    public class UnitTestProblem1
    {
        /// <summary>
        /// Test year of Manufacturing is returning Current Year
        /// </summary>
        [Fact]
        public void TestForManufacturingYear()
        {

            CarsCreator newCar = new CarsCreator();
            var actual = newCar.GetToy().YearOfManufacturing;
            Assert.Equal(2022, actual);

        }

        /// <summary>
        /// This Test method will test Max Stack height method in Rainbow Stacker Class
        /// </summary>
        [Fact]
        public void TestForMaxStackHeightMethod()
        {
            RainbowStackers myRainStack = new RainbowStackers(true, 7, 14);
            var actual = myRainStack.MaxStackHeight();
            Assert.Equal( 7 * 14 , actual);

        }

        /// <summary>
        /// This Test Method will test AmountOf water for refill method in stuffed animals
        /// </summary>
        [Fact]
        public void TestAmountofWaterRefill()
        {
            StuffedAnimals myStuffed = new StuffedAnimals(true, false, true);
            var actual = myStuffed.AmountOfWaterForRefill();
            Assert.Equal(myStuffed.Weight*1.5, actual);

        }
 
    }
}
