using AbstractFactory.Interface;

namespace AbstractFactory.Bikes
{
    class ElectricBikeHonda : IBike
    {
        public string Name()
        {
            return "I'm a motor bike of Honda";
        }
    }
}
