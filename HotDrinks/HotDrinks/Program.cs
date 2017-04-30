using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotDrinks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IHotDrink> hotDrinks = new List<IHotDrink> {
                new CupOfCoffee(),
                new CupOfTea(),
                new CupOfCoffee("Robusta", false, false, 2, "Description"),
                new CupOfCoffee("Arabica", true, false, 0,"")
            };
            //foreach (var drink in hotDrinks)
            //    drink.AddShugar(1);
            foreach(var drink in hotDrinks)
                Console.WriteLine(drink);
        }
    }
}
