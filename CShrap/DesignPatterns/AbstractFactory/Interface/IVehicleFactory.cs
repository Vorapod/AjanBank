namespace AbstractFactory.Interface
{
    public interface IVehicleFactory
    {
        IBike GetBike(string bike);
        ICar GetCar(string car);
    }
}
