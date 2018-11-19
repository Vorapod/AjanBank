using Prototype.Prototype;
using System;

namespace Prototype
{

    /// <summary>
    /// The 'ConcretePrototype' class
    /// </summary>
    class Color : ColorPrototype
    {
        private int _red, _green, _blue;
        public Color(int red, int green, int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }

        // Create a shallow copy
        public override ColorPrototype Clone()
        {
            Console.WriteLine($"Cloning color RGB: {_red},{_green},{_blue}");

            return MemberwiseClone() as ColorPrototype;
        }
    }
}
