using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{

    /// <summary>
    /// This is an interface for creating the objects.
    /// </summary>
    public interface IFactory
    {
        string GetName();
    }
}
