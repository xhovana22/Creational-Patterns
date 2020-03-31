using AbstractFactorypatter.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorypatter.Products
{

    class Wolf : Carnivore

    {
        public override void Eat(Herbivore h)
        {
            // Eat Bison

            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}
