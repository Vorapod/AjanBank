using AbstractFactory.Cat;
using AbstractFactory.Dog;
using AbstractFactory.Enum;
using AbstractFactory.Interface;
using System;

namespace AbstractFactory.Farm
{
    class AbcFarm : IFarm
    {
        public string Walk()
        {
            return "Animal in farm ABC are walking";
        }

        public IDog GetDog(EnumColor color)
        {
            switch (color)
            {
                case EnumColor.TwoTone:
                    return new BulldogFarmAbc();
                case EnumColor.OneTone:
                    return new GoldenFarmAbc();
                default:
                    throw new Exception();
            }
        }

        public ICat GetCat(EnumColor color)
        {
            switch (color)
            {
                case EnumColor.TwoTone:
                    return new PersianFarmAbc();
                default:
                    return new PersianFarmAbc();
            }
        }
    }
}
