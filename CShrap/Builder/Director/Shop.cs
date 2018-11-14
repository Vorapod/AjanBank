using Builder.Builder;

namespace Builder.Director
{
    /// <summary>
    /// The 'Director' class 
    //  constructs an object using the Builder interface
    /// </summary>
    class Shop
    {
        // Builder uses a complex series of steps
        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildWheels();
            vehicleBuilder.BuildDoors();
        }

    }
}
