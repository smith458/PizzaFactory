using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMaker
{
    public class PizzaStore
    {
        public PizzaStore(PizzaFactory factory)
        {
            _factory = factory;
        }

        public Pizza OrderPizza(PizzaTypes type)
        {
            Pizza pizza;

            pizza = _factory.CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            pizza.Deliver();

            return pizza;
        }

        PizzaFactory _factory;
    }
}
