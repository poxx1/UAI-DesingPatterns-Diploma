using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Builder
{
    public class Director
    {
        //Es la UserInterface que crea las cosas. No sencesariamente tiene que ser la UI.
        public void PrintPizzas()
        {
            var tana = new ItalianPizzaBuilder();
            var rara = new LightPizzaBuilder();
            var muzza = new MargheritaPizzaBuilder();

            PizzaBuilder builder = tana as PizzaBuilder;
            Pizza pizza = builder.BuildPizza();

            Console.WriteLine(pizza.ToString());

            builder = rara as PizzaBuilder;
            pizza = builder.BuildPizza();

            Console.WriteLine(pizza.ToString());

            builder = muzza as PizzaBuilder;
            pizza = builder.BuildPizza();

            Console.WriteLine(pizza.ToString());
        }
    }
}
