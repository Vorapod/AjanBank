using AbstractFactory.Interface;

namespace AbstractFactory.Cars
{
    class EcoCarYamaha : ICar
    {
        public string Name()
        {
            return "I'm a eco car of Yamaha";
        }
    }
}
