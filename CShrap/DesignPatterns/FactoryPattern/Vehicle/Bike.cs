namespace FactoryPattern.Vehicle
{
    /// <summary>
    /// This is a class which implements the Product interface.
    /// </summary>
    /// <seealso cref="FactoryPattern.IFactory" />
    class Bike : IFactory
    {
        public string GetVehicle()
        {
            return "I'm a sport cars.";
        }
    }
}
