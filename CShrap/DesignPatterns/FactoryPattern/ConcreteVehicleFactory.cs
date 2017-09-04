using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Vehicle;

namespace FactoryPattern
{
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
