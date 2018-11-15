using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderHappyNew.Builder;

namespace BuilderHappyNew.Director
{
    class Mcdonalds
    {
        public void Construct(IMenuBuilder menu)
        {
            menu.BuildBurger();
            menu.BuildDrink();
            menu.BuildFrenchFries();
        }
    }
}
