using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorManager manager = new ColorManager();
            
            //Initialze with standard color
            manager["red"] = new Color(255, 0, 0);
            manager["green"] = new Color(0, 255, 0);
            manager["blue"] = new Color(0, 0, 255);

            // User clones selected colors
            Color color1 = manager["red"].Clone() as Color;
        }
    }
}
