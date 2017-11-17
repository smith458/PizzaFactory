using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMaker
{
    public abstract class Pizza
    {
        internal String name;
        internal String dough;
        internal String sauce;
        internal String cheese;
        internal List<String> toppings;


        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Baking at 350 for 25 minutes...");
        }

        public void Cut()
        {
            Console.WriteLine("Cut the pizza diagonally.");
        }

        public void Box()
        {
            Console.WriteLine("Put the pizza in a standard box.");
        }

        public void Deliver()
        {
            Console.WriteLine("The pizza is being delivered by car.");
        }

        public string GetName()
        {
            return name;
        }
    }
}
