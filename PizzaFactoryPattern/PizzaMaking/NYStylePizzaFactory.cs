using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaMaking
{
    public class NYStylePizzaFactory : PizzaFactory
    {
        public override Pizza CreatePizza(PizzaTypes type)
        {
            Pizza pizza;
            switch (type)
            {
                case PizzaTypes.Cheese:
                    pizza = new NYCheesePizza();
                    break;
                case PizzaTypes.Pepperoni:
                    pizza = new NYPepperoniPizza();
                    break;
                case PizzaTypes.Sausage:
                    pizza = new NYSausagePizza();
                    break;
                case PizzaTypes.Hawaiian:
                    pizza = new NYHawaiianPizza();
                    break;
                case PizzaTypes.Veggie:
                    pizza = new NYVeggiePizza();
                    break;
                default:
                    pizza = null;
                    break;
            }

            return pizza;
        }
    }
}
