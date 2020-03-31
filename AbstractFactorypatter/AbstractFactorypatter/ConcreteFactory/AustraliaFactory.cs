using AbstractFactorypatter.AbstractFactory;
using AbstractFactorypatter.AbstractProducts;
using AbstractFactorypatter.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorypatter.ConcreteFactory
{
    class AustraliaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Koala();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
