using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /// <summary>
    /// This is an abstract class and declares the factory method, which returns an object of type Product.
    /// </summary>
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string type);
    }
}
