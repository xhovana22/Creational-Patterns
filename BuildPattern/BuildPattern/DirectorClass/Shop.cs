using BuildPattern.BuilderClass;
using BuildPattern.ConcreteBuilder;
using BuildPattern.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildPattern.DirectorClass
{
   //director class
    class Shop

    {
        // Builder uses a complex series of steps

        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }
    }

   
}
