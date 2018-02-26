using System;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant
{
    partial class Program
    {
        static void Main(string[] args)
        {
            /* test your classes in the Main method by creating several menu items, 
             * adding them to a menu, and printing the menu to the screen. */

            Menu Outback = new Menu("Outback");

            MenuItem steakFilet = new MenuItem("Steak Filet", "6 oz filet mignon with garlic cream sauce, fresh veg, and mashed potatoes", 15.99, "Entree");
            MenuItem salad = new MenuItem("Aussie Salad", "Peppery steak bits over garden lettuce with creamy ranch dressing", 12.99, "Appetizer");
            MenuItem iceCream = new MenuItem("Boomerang Bowl", "Chocolate, vanilla, and strawberry ice creams topped with chocolate sprinkles", 9.50, "Dessert");

            Outback.AddItem(steakFilet);
            Outback.AddItem(salad);
            Outback.AddItem(iceCream);

            Console.WriteLine(Outback.ToString());
            Console.ReadLine();
        }
    }


    

   
}
