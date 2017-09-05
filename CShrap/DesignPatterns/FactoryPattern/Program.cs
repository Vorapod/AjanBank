using FactoryPattern.Vehicle;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:How is different
            IFactory fac = new Bike();
            Console.WriteLine($"{fac.GetVehicle()}");

            fac = new Car();
            Console.WriteLine($"{fac.GetVehicle()}");


            VehicleFactory vehicel = new ConcreteVehicleFactory();

            IFactory factory = vehicel.GetVehicle("Bike");
            Console.WriteLine($"{factory.GetVehicle()}");

            factory = vehicel.GetVehicle("Scooter");
            Console.WriteLine($"{factory.GetVehicle()}");

            Console.ReadLine();
        }
    }
}
