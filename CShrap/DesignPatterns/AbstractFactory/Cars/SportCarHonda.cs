using AbstractFactory.Interface;

namespace AbstractFactory.Cars
{
    class SportCarHonda : ICar
    {
        public string Name()
        {
            return "I'm a sport car of honda.";
        }
    }
}
