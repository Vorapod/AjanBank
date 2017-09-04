using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Products;

namespace FactoryPattern
{
    /// <summary>
    /// This is a class which implements the Creator class and overrides the factory method to return an instance of a ConcreteProduct.
    /// </summary>
    class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string type)
        {
            switch (type)
            {
                case "Sport": return new SportCar();
                case "Eco": return new EcoCar();
                default: throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", type));
            }
        }
    }
}
