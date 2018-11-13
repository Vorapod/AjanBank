using AbstractFactory.Interface;

namespace AbstractFactory.Dog
{
    class GoldenFarmAbc : IDog
    {
        public string Bark()
        {
            return "Golden from farm ABC bark ... hong hong hong !!";
        }
    }
}
