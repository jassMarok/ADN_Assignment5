using System;
using Xunit;
using Problem1;

namespace TestProject
{
    public class UnitTestProblem1
    {
        [Fact]
        public void Test1()
        {
            

            CarsCreator newCar = new CarsCreator();

            var actual = newCar.GetToy().YearOfManufacturing;

            Assert.Equal(2022, actual);

            
        }
    }
}
