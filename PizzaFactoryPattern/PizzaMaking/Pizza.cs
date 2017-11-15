using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaMaking
{
    public abstract class Pizza
    {
        public void Prepare()
        {
            
        }

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

    }
}
