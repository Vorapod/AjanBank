using FactoryPattern.Vehicle;
using System;

namespace FactoryPattern
{
    class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string type)
        {
            switch (type)
            {
                case "Bike": return new Bike();
                case "Scooter": return new Scooter();
                default: throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", type));
            }
        }
    }
}
