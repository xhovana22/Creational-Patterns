﻿using AbstractFactorypatter.AbstractFactory;
using AbstractFactorypatter.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorypatter
{
   //Client Class

    class AnimalWorld

    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        // Constructor

        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}

