using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Vehicle;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //How is different
            IFactory productA = new SportCar();
            Console.WriteLine($"{productA.GetVehicle()}");

            IFactory productB = new EcoCar();
            Console.WriteLine($"{productB.GetVehicle()}");


            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory sportCar = factory.GetVehicle("Sport");
            Console.WriteLine($"{sportCar.GetVehicle()}");

            IFactory ecoCar = factory.GetVehicle("Eco");
            Console.WriteLine($"{ecoCar.GetVehicle()}");

            Console.ReadLine();
        }
    }
}
