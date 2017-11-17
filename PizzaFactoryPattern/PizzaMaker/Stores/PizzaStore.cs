using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMaker
{
    public abstract class PizzaStore
    {
        IngredientFactory _factory;

        public Pizza OrderPizza(PizzaTypes type)
        {
            Pizza pizza;

            pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            pizza.Deliver();

            return pizza;
        }

        internal abstract Pizza CreatePizza(PizzaTypes type);
    }
}
