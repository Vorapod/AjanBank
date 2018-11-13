using AbstractFactory.Interface;

namespace AbstractFactory.Cat
{
    class PersianFarmAbc : ICat
    {
        public string Meow()
        {
            return "Persian from farm ABC meow meow meow !!";
        }
    }
}
