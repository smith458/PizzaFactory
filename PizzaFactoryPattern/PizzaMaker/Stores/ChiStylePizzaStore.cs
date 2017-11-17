using PizzaMaker.IngredientFactories;

namespace PizzaMaker
{
    public class ChiStylePizzaStore : PizzaStore
    {
        internal override Pizza CreatePizza(PizzaTypes type)
        {
            Pizza pizza;
            IngredientFactory _factory = new ChiIngredientFactory();
            switch (type)
            {
                case PizzaTypes.Cheese:
                    pizza = new CheesePizza(_factory);
                    break;
                case PizzaTypes.Pepperoni:
                    pizza = new PepperoniPizza(_factory);
                    break;
                case PizzaTypes.Sausage:
                    pizza = new SausagePizza(_factory);
                    break;
                case PizzaTypes.Hawaiian:
                    pizza = new HawaiianPizza(_factory);
                    break;
                case PizzaTypes.Veggie:
                    pizza = new VeggiePizza(_factory);
                    break;
                default:
                    pizza = null;
                    break;
            }

            return pizza;
        }
    }
}
