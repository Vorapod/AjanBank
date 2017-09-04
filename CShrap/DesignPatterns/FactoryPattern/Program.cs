using FactoryPattern.Vehicle;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //How is different
            IFactory productA = new Bike();
            Console.WriteLine($"{productA.GetVehicle()}");

            IFactory productB = new Scooter();
            Console.WriteLine($"{productB.GetVehicle()}");


            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory bike = factory.GetVehicle("Bike");
            Console.WriteLine($"{bike.GetVehicle()}");

            IFactory scooter = factory.GetVehicle("Scooter");
            Console.WriteLine($"{scooter.GetVehicle()}");

            Console.ReadLine();
        }
    }
}
