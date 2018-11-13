using AbstractFactory.Interface;

namespace AbstractFactory.Cat
{
    class PersianFarmXyz : ICat
    {
        public string Meow()
        {
            return "Persian from farm XYZ meow meow meow !!";
        }
    }
}
