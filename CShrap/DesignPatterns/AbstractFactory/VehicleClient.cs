using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interface;

namespace AbstractFactory
{

    class VehicleClient
    {
        private IBike bike;
        private ICar car;

        public VehicleClient(IVehicleFactory factory, string type)
        {
            bike = factory.GetBike(type);
            car = factory.GetCar(type);
        }

        public string GetBikeName()
        {
            return bike.Name();
        }

        public string GetCarName()
        {
            return car.Name();
        }

    }
}
