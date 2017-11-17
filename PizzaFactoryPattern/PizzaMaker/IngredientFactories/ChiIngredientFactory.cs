using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMaker.IngredientFactories
{
    public class ChiIngredientFactory : IngredientFactory
    {
        public override string CreateCheese()
        {
            return "";
        }

        public override string CreateDough()
        {
            return "";
        }

        public override string CreateSauce()
        {
            return "";
        }

        public override List<string> CreateToppings()
        {
            return new List<string> { "" };
        }
    }
}
