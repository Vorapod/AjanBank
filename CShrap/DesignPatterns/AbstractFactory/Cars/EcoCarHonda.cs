using AbstractFactory.Interface;

namespace AbstractFactory.Cars
{
    class EcoCarHonda : ICar
    {
        public string Name()
        {
            return "I'm a eco car of Honda.";
        }
    }
}
