using AbstractFactory.Bikes;
using AbstractFactory.Cars;
using AbstractFactory.Interface;
using System;

namespace AbstractFactory.Factory
{
    class YamahaFactory : IVehicleFactory
    {
        public IBike GetBike(string bike)
        {
            switch (bike)
            {
                case "Regular":
                    return new RegularBikeYamaha();
                case "Sport":
                    return new ElectricBikeYamaha();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", bike));
            }
        }
        public ICar GetCar(string car)
        {
            switch (car)
            {
                case "Regular":
                    return new EcoCarYamaha();
                case "Sport":
                    return new SportCarYamaha();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", car));
            }
        }
    }
}
