using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Prototype
{
    abstract class ColorPrototype
    {
        /// <summary>
        /// The 'Prototype' abstract class
        /// </summary>
        public abstract ColorPrototype Clone();
    }
}
