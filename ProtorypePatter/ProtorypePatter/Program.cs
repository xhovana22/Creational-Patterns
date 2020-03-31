
using ProtorypePatter.ConcretePrototype;
using ProtorypePatter.PrototypeManager;
using System;
using System.Drawing;

namespace ProtorypePatter
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorManager colormanager = new ColorManager();

            // Initialize with standard colors

            colormanager["red"] = new Colors(255, 0, 0);
            colormanager["green"] = new Colors(0, 255, 0);
            colormanager["blue"] = new Colors(0, 0, 255);

            // User adds personalized colors

            colormanager["angry"] = new Colors(255, 54, 0);
            colormanager["peace"] = new Colors(128, 211, 128);
            colormanager["flame"] = new Colors(211, 34, 20);

            // User clones selected colors

            Colors color1 = colormanager["red"].Clone() as Colors;
            Colors color2 = colormanager["peace"].Clone() as Colors;
            Colors color3 = colormanager["flame"].Clone() as Colors;

            // Wait for user

            Console.ReadKey();
        }
    }
}
