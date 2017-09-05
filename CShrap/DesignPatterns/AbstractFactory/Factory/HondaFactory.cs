using AbstractFactory.Bikes;
using AbstractFactory.Cars;
using AbstractFactory.Interface;
using System;

namespace AbstractFactory.Factory
{
    class HondaFactory : IVehicleFactory
    {
        public IBike GetBike(string bike)
        {
            switch (bike)
            {
                case "Regular":
                    return new RegularBikeHonda();
                case "Sport":
                    return new MotorBikeHonda();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", bike));
            }
        }
        public ICar GetCar(string car)
        {
            switch (car)
            {
                case "Regular":
                    return new EcoCarHonda();
                case "Sport":
                    return new SportCarHonda();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", car));
            }
        }
    }
}
