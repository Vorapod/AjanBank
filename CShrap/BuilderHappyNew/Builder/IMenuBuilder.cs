using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderHappyNew.Builder
{
    public interface IMenuBuilder
    {
        Menu Menu { get; }
        void BuildBurger();
        void BuildDrink();
        void BuildFrenchFries();
    }
}
