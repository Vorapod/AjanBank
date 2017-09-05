using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interface;

namespace AbstractFactory.Cars
{
    class SportCarYamaha : ICar
    {
        public string Name()
        {
            return "I'm a sport car of yamaha";
        }
    }
}
