using AbstractFactorypatter.AbstractFactory;
using AbstractFactorypatter.AbstractProducts;
using AbstractFactorypatter.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorypatter.ConcreteFactory
{

    class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

    }
}
