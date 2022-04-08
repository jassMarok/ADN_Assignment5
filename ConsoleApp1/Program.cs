using System;
using Problem1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarsCreator newCar = new CarsCreator();

            RainbowStackersCreator newStack = 
                new RainbowStackersCreator();

            StuffedAnimalsCreator newStuff =
                new StuffedAnimalsCreator();


            RainbowStackers myRainStack = new RainbowStackers(true,7,14);

            StuffedAnimals myStuffed = new StuffedAnimals(true, false, true);


            Console.WriteLine(newStack.GetToy().Description);

            


            Console.ReadLine();




        }
    }
}
