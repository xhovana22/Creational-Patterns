using AbstractFactorypatter.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorypatter.AbstractFactory
{
    abstract class ContinentFactory
    {
     
            public abstract Herbivore CreateHerbivore();
            public abstract Carnivore CreateCarnivore();
        
    }
}
