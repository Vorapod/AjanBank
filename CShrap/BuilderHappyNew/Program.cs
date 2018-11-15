using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderHappyNew.Builder;
using BuilderHappyNew.Director;

namespace BuilderHappyNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Mcdonalds mac = new Mcdonalds();
            // Lets have the Builder class ready
            IMenuBuilder menuBuilder = null;

            menuBuilder = new HappyNewOne();
            mac.Construct(menuBuilder);
            Console.WriteLine(menuBuilder.Menu.ToString());

            menuBuilder = new HappyNewTwo();
            mac.Construct(menuBuilder);
            Console.WriteLine(menuBuilder.Menu.ToString());

            Console.ReadKey();
        }
    }
}
