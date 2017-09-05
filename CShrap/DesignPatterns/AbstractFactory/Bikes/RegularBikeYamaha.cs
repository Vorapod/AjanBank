using AbstractFactory.Interface;
using System;

namespace AbstractFactory.Bikes
{
    class RegularBikeYamaha : IBike
    {
        public string Name()
        {
            return "I'm a regular bike of yamaha";
        }
    }
}
