using BuildPattern.ConcreteBuilder;
using BuildPattern.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern.BuilderClass
{
   //builder class

    abstract class VehicleBuilder

    {
        protected Vehicle vehicle;

        // Gets vehicle instance

        public Vehicle Vehicle
        {
            get { return vehicle; }
        }

        // Abstract build methods

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();

       
    }

}
