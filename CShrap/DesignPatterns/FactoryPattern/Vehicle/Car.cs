namespace Factory.Vehicle
{
    /// <summary>
    /// This is a class which implements the Product interface.
    /// </summary>
    /// <seealso cref="Factory.IFactory" />
    class Car : IFactory
    {
        public string GetVehicle()
        {
            return "I'm a cars.";
        }
    }
}
