using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaMaking
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
            Console.WriteLine("Something");
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            pizza.Deliver();

            return pizza;
        }

        PizzaFactory _factory;
    }
}
