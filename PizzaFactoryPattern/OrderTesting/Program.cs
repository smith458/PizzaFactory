using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaMaker;

namespace OrderTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore store = new PizzaStore(new NYStylePizzaFactory());

            store.OrderPizza(PizzaTypes.Cheese);
        }
    }
}
