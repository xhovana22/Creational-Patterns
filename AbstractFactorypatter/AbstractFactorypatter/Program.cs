using AbstractFactorypatter.AbstractFactory;
using AbstractFactorypatter.ConcreteFactory;
using System;

namespace AbstractFactorypatter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and run the African animal world

            ContinentFactory australia = new AustraliaFactory();
            AnimalWorld world = new AnimalWorld(australia);
            world.RunFoodChain();

            // Create and run the American animal world

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            // Wait for user input

            Console.ReadKey();
        }
    }
}
