using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMaker
{
    public abstract class IngredientFactory
    {
        public abstract String CreateDough();
        public abstract String CreateSauce();
        public abstract String CreateCheese();
        public abstract List<String> CreateToppings();
    }
}
