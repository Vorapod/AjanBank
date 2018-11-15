using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderHappyNew.Enum;

namespace BuilderHappyNew.Builder
{
    public class Menu
    {
        public Menu(string name)
        {
            Name = name;
        }
        private string Name;
        public EnumBurger Burger { get; set; }
        public EnumFrenceFries FrenceFries { get; set; }
        public EnumDrink Drink { get; set; }


        // Methiod to display phone details in our own representation
        public override string ToString()
        {
            return $"Name: {Name}, Burger: {Burger}, FrenceFries: {FrenceFries}, Drink: {Drink}";
        }
    }
}
