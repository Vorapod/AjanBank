using Factory.Vehicle;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory vehicel = new ConcreteVehicleFactory();

            IFactory factory = vehicel.GetVehicle("Bike");
            Console.WriteLine($"{factory.GetVehicle()}");

            factory = vehicel.GetVehicle("Scooter");
            Console.WriteLine($"{factory.GetVehicle()}");

            Console.ReadLine();
        }
    }
}
