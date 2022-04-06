using System;

namespace Problem1
{
    public abstract class ToyCreator
    {
        public abstract ToyFactory GetToy();
    }

    public class CarsCreator : ToyCreator {

        public override ToyFactory GetToy() {

            return new Cars();

        }

    }

    public class DollHousesCreator : ToyCreator
    {

        public override ToyFactory GetToy()
        {

            return new DollHouses();

        }

    }

    public class RainbowStackersCreator : ToyCreator
    {

        public override ToyFactory GetToy()
        {

            return new RainbowStackers();

        }

    }

    public class StuffedAnimalsCreator : ToyCreator
    {

        public override ToyFactory GetToy()
        {

            return new StuffedAnimals();

        }

    }
}



