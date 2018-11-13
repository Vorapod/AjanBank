using AbstractFactory.Interface;

namespace AbstractFactory.Dog
{
    class BulldogFarmXyz : IDog
    {
        public string Bark()
        {
            return "Bulldog from farm XYZ bark ... hong hong hong !!";
        }
    }
}
