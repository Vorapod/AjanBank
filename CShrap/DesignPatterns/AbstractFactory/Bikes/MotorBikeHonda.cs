using AbstractFactory.Interface;

namespace AbstractFactory.Bikes
{
    class MotorBikeHonda : IBike
    {
        public string Name()
        {
            return "I'm a motor bike of Honda";
        }
    }
}
