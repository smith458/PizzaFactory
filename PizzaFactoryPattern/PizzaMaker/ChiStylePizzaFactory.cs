using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMaker
{
    public class ChiStylePizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza(PizzaTypes type)
        {
            Pizza pizza;
            switch (type)
            {
                case PizzaTypes.Cheese:
                    pizza = new ChiCheesePizza();
                    break;
                case PizzaTypes.Pepperoni:
                    pizza = new ChiPepperoniPizza();
                    break;
                case PizzaTypes.Sausage:
                    pizza = new ChiSausagePizza();
                    break;
                case PizzaTypes.Hawaiian:
                    pizza = new ChiHawaiianPizza();
                    break;
                case PizzaTypes.Veggie:
                    pizza = new ChiVeggiePizza();
                    break;
                default:
                    pizza = null;
                    break;
            }

            return pizza;
        }
    }
}
