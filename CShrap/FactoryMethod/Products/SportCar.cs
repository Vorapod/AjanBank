using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Products
{
    /// <summary>
    /// This is a class which implements the Product interface.
    /// </summary>
    /// <seealso cref="FactoryPattern.IFactory" />
    class SportCar : IFactory
    {
        public string GetName()
        {
            return "I'm a sport cars.";
        }
    }
}
