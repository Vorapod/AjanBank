using Factory.Vehicle;
using System;

namespace Factory
{
    class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string type)
        {
            switch (type)
            {
                case "Bike": return new Bike();
                case "Car": return new Car();
                default: throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", type));
            }
        }
    }
}
