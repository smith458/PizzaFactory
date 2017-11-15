using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMaker
{
    public abstract class PizzaFactory
    {
        public abstract Pizza CreatePizza(PizzaTypes type);
    }
}
