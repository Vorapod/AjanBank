using AbstractFactory.Cat;
using AbstractFactory.Dog;
using AbstractFactory.Enum;
using AbstractFactory.Interface;
using System;

namespace AbstractFactory.Farm
{
    class XyzFarm : IFarm
    {
        public string Walk()
        {
            return "Animal in farm XYZ are walking";
        }

        public IDog GetDog(EnumColor color)
        {
            switch (color)
            {
                case EnumColor.TwoTone:
                    return new BulldogFarmXyz();
                case EnumColor.OneTone:
                    return new GoldenFarmXyz();
                default:
                    throw new Exception();
            }
        }

        public ICat GetCat(EnumColor color)
        {
            switch (color)
            {
                case EnumColor.TwoTone:
                    return new PersianFarmXyz();
                default:
                    return new PersianFarmXyz();
            }
        }
    }
}
