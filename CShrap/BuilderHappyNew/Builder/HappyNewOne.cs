using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderHappyNew.Enum;

namespace BuilderHappyNew.Builder
{
    // This is the "ConcreteBuilder" class
    class HappyNewOne : IMenuBuilder
    {
        public Menu Menu { get; }

        public HappyNewOne()
        {
            Menu = new Menu("Happy_New_One");
        }
        public void BuildBurger()
        {
            Menu.Burger = EnumBurger.SanuralChicken;
        }

        public void BuildDrink()
        {
            Menu.Drink = EnumDrink.Water;
        }

        public void BuildFrenchFries()
        {
            Menu.FrenceFries= EnumFrenceFries.Small;
        }
    }
}
