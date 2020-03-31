using AbstractFactorypatter.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactorypatter.Products
{
 
    class Lion : Carnivore

    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest

            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }

}
