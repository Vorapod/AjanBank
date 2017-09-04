namespace FactoryPattern.Vehicle
{
    /// <summary>
    /// This is a class which implements the Product interface.
    /// </summary>
    /// <seealso cref="FactoryPattern.IFactory" />
    class Car : IFactory
    {
        public string GetVehicle()
        {
            return "I'm a cars.";
        }
    }
}
