using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interface;

namespace AbstractFactory.Bikes
{
    class ElectricBikeYamaha : IBike
    {
        public string Name()
        {
            return "I'm a motor bike of yamaha";
        }
    }
}
