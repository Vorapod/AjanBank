using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Products;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //How is different
            IFactory productA = new SportCar();
            Console.WriteLine($"{productA.GetName()}");

            IFactory productB = new EcoCar();
            Console.WriteLine($"{productB.GetName()}");


            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory sportCar = factory.GetVehicle("Sport");
            Console.WriteLine($"{sportCar.GetName()}");

            IFactory ecoCar = factory.GetVehicle("Eco");
            Console.WriteLine($"{ecoCar.GetName()}");

            Console.ReadLine();
        }
    }
}
