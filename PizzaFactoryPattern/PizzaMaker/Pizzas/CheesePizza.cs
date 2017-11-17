﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMaker
{
    public class CheesePizza : Pizza
    {
        internal IngredientFactory _factory;

        public CheesePizza(IngredientFactory factory)
        {
            _factory = factory;
        }

        public override void Prepare()
        {
            dough = _factory.CreateDough();
            sauce = _factory.CreateSauce();
            cheese = _factory.CreateCheese();
            toppings = _factory.CreateToppings();
        }
    }
}
