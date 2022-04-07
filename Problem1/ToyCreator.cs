using System;

namespace Problem1
{
    public abstract class ToyCreator
    {
        public abstract ToyFactory GetToy();
    }

    public class CarsCreator : ToyCreator {

        public override ToyFactory GetToy() {

            return new Cars(true,4,true);

        }

    }

    public class DollHousesCreator : ToyCreator
    {

        public override ToyFactory GetToy()
        {

            return new DollHouses(true, 4, true);

        }

    }

    public class RainbowStackersCreator : ToyCreator
    {

        public override ToyFactory GetToy()
        {

            return new RainbowStackers( true,7,2);

        }

    }

    public class StuffedAnimalsCreator : ToyCreator
    {

        public override ToyFactory GetToy()
        {

            return new StuffedAnimals(true,false,true);

        }

    }
}



