using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interface;

namespace AbstractFactory
{
    class FarmClient
    {
        private IDog _dog;
        private ICat _cat;

        public FarmClient(IFarm farm, Enum.EnumColor color)
        {
            _dog = farm.GetDog(color);
            _cat = farm.GetCat(color);
        }

        public string DogBark()
        {
            return _dog.Bark();
        }

        public string CatMeow()
        {
            return _cat.Meow();
        }
    }
}
