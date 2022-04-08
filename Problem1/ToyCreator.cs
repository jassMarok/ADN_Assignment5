///I, Damanpreet Singh, student number 000741359, certify that all code submitted is my own work;
/// that I have not copied it from any other source.
/// I also certify that I have not allowed my work to be copied by others.
using System;

namespace Problem1
{
    /// <summary>
    /// The 'ToyCreator' abstract class
    /// </summary>
    public abstract class ToyCreator
    {
        public abstract ToyFactory GetToy();
    }

    /// <summary>
    /// A 'Concrete CarsCreator' class
    /// </summary>
    public class CarsCreator : ToyCreator {

        public override ToyFactory GetToy() {

            return new Cars(true,4,true);

        }

    }

    /// <summary>
    /// A 'Concrete DollHousesCreator' class
    /// </summary>
    public class DollHousesCreator : ToyCreator
    {

        public override ToyFactory GetToy()
        {

            return new DollHouses(true, 4, true);

        }

    }

    /// <summary>
    /// A 'Concrete RainbowStackersCreator' class
    /// </summary>
    public class RainbowStackersCreator : ToyCreator
    {

        public override ToyFactory GetToy()
        {

            return new RainbowStackers( true,7,2);

        }

    }

    /// <summary>
    /// A 'Concrete StuffedAnimalsCreator' class
    /// </summary>
    public class StuffedAnimalsCreator : ToyCreator
    {

        public override ToyFactory GetToy()
        {

            return new StuffedAnimals(true,false,true);

        }

    }
}



