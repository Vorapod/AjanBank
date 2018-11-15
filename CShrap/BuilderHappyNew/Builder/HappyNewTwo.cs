using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderHappyNew.Enum;

namespace BuilderHappyNew.Builder
{
    // This is the "ConcreteBuilder" class
    class HappyNewTwo : IMenuBuilder
    {
        public Menu Menu { get; }

        public HappyNewTwo()
        {
            Menu = new Menu("Happy_New_Two");
        }
        public void BuildBurger()
        {
            Menu.Burger = EnumBurger.SamuraiPork;
        }

        public void BuildDrink()
        {
            Menu.Drink = EnumDrink.Soda;
        }

        public void BuildFrenchFries()
        {
            Menu.FrenceFries= EnumFrenceFries.Big;
        }
    }
}
