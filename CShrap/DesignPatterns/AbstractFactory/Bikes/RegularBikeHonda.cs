using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interface;

namespace AbstractFactory.Bikes
{
    class RegularBikeHonda : IBike
    {
        public string Name()
        {
            return "I'm a regular bike of Honda";
        }
    }
}
