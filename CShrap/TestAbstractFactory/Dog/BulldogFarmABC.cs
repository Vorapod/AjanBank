using AbstractFactory.Interface;

namespace AbstractFactory.Dog
{
    class BulldogFarmAbc : IDog
    {
        public string Bark()
        {
            return "Bulldog from farm ABC bark ... hong hong hong !!";
        }
    }
}
