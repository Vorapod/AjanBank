using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using AbstractFactory.Enum;
using AbstractFactory.Farm;
using AbstractFactory.Interface;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FarmClient farmABC = new FarmClient(new AbcFarm(), EnumColor.OneTone);
            Console.WriteLine("****** Farm ABC Dog & Car color one tone********");
            Console.WriteLine(farmABC.DogBark());
            Console.WriteLine(farmABC.CatMeow());
            Console.WriteLine();
            Console.WriteLine("****** Farm ABC Dog & Car color two tone********");
            farmABC = new FarmClient(new AbcFarm(), EnumColor.TwoTone);
            Console.WriteLine(farmABC.DogBark());
            Console.WriteLine(farmABC.CatMeow());
            Console.WriteLine();
            //Farm XYZ
            FarmClient farmXYZ = new FarmClient(new XyzFarm(), EnumColor.OneTone);
            Console.WriteLine("****** Farm XYZ Dog & Car color one tone********");
            Console.WriteLine(farmXYZ.DogBark());
            Console.WriteLine(farmXYZ.CatMeow());
            Console.WriteLine();
            Console.WriteLine("****** Farm XYZ Dog & Car color two tone********");
            farmXYZ = new FarmClient(new AbcFarm(), EnumColor.TwoTone);
            Console.WriteLine(farmXYZ.DogBark());
            Console.WriteLine(farmXYZ.CatMeow());

            Console.ReadKey();
        }
    }
}
