using AbstractFactory.Enum;

namespace AbstractFactory.Interface
{
    public interface IFarm
    {
        string Walk();
        IDog GetDog(EnumColor color);
        ICat GetCat(EnumColor color);
    }
}
