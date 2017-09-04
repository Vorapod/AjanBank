namespace FactoryPattern
{
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string type);
    }
}
