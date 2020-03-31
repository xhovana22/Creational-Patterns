using ProtorypePatter.PrototypeClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ProtorypePatter.ConcretePrototype
{
    class Colors : ColorPrototype

    {
        private int _red;
        private int _green;
        private int _blue;

        // Constructor

        public Colors(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }

        // Create a shallow copy

        public override ColorPrototype Clone()
        {
            Console.WriteLine(
              "Cloning color RGB: {0,3},{1,3},{2,3}",
              _red, _green, _blue);

            return this.MemberwiseClone() as ColorPrototype;
        }

       
    }
}