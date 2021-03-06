﻿using AbstractFactory.Factory;
using AbstractFactory.Interface;
using System;

namespace AbstractFactory
{
    /// <summary>
    /// Creates an instance of several families of classes
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory honda = new HondaFactory();
            VehicleClient hondaClient = new VehicleClient(honda, "Regular");

            Console.WriteLine("****** Honda Regular********");
            Console.WriteLine("Bike: " + hondaClient.GetBikeName());
            Console.WriteLine("Car:" + hondaClient.GetCarName());

            Console.WriteLine();

            hondaClient = new VehicleClient(honda, "Sport");
            Console.WriteLine("****** Honda Sport********");
            Console.WriteLine("Bike: " + hondaClient.GetBikeName());
            Console.WriteLine("Car:" + hondaClient.GetCarName());

            Console.WriteLine();

            IVehicleFactory yamaha = new YamahaFactory();
            VehicleClient yamahaClient = new VehicleClient(yamaha, "Regular");

            Console.WriteLine("****** Yamaha Regular********");
            Console.WriteLine("Bike: " + yamahaClient.GetBikeName());
            Console.WriteLine("Car:" + yamahaClient.GetCarName());

            Console.WriteLine();
            yamahaClient = new VehicleClient(yamaha, "Sport");
            Console.WriteLine("****** Yamaha Sport********");
            Console.WriteLine("Bike: " + yamahaClient.GetBikeName());
            Console.WriteLine("Car:" + yamahaClient.GetCarName());

            Console.ReadKey();
        }
    }
}
