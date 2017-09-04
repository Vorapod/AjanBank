using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Vehicle
{
    /// <summary>
    /// This is a class which implements the Product interface.
    /// </summary>
    /// <seealso cref="FactoryPattern.IFactory" />
    class EcoCar : IFactory
    {
        public string GetVehicle()
        {
            return "I'm a eco cars.";
        }
    }
}
