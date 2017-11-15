using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaMaking
{
    public abstract class PizzaFactory
    {
        public abstract Pizza CreatePizza(PizzaTypes type);
    }
}
