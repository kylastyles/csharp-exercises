using System;


namespace Restaurant
{
    partial class Program
    {
        static void Main(string[] args)
        {
            /* test your classes in the Main method by creating several menu items, 
             * adding them to a menu, and printing the menu to the screen. */

            Menu KEats = new Menu("K's Eats");

            MenuItem steakFilet = new MenuItem("Steak Filet", "6 oz filet mignon with garlic cream sauce, fresh veg, and mashed potatoes", 15.99, "Entree");
            MenuItem mozzBites = new MenuItem("Mozz Bites", "Fried mozzarella with our signature marinara", 12.99, "Appetizer");
            MenuItem iceCream = new MenuItem("Super Sundae", "Chocolate, vanilla, and strawberry ice creams topped with chocolate sprinkles", 9.50, "Dessert");

            KEats.AddItem(steakFilet);
            KEats.AddItem(mozzBites);
            KEats.AddItem(iceCream);

            MenuItem chicken = new MenuItem("Pamela's Chicken", "Roast half chicken with sweet potato fries and corn", 14.50, "Entree");
            KEats.AddItem(chicken);

            Console.WriteLine(KEats.ToString());
            Console.ReadLine();
        }
    }


    

   
}
