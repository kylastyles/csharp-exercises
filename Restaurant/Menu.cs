using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Restaurant
{
    public class Menu
    {
        private List<MenuItem> menuItems;

        public List<MenuItem> MenuItems
        {
            get { return menuItems; }
            set => menuItems = value;
        }

        private string lastUpdate;

        public string LastUpdate
        {
            get { return lastUpdate; }
            set { lastUpdate = value; }
        }


        //public methods

        public void AddItem (MenuItem x)
        {   
            try
            {
                menuItems.Add(x);
                this.LastUpdate = DateTime.Now.ToString();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No item present");
            }
        }

        public void RemoveItem (MenuItem x)
        {
            menuItems.Remove(x);
            this.LastUpdate = DateTime.Now.ToString();
        }

        public override string ToString ()
        {
            string menuprint = "";
            try
            {
                foreach (MenuItem x in menuItems)
                {
                    menuprint += x.ToString() + "\n";
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Menu is empty");
            }
            return menuprint;
        }

    //constructors
        public Menu ()
        {
            menuItems = new List<MenuItem>();
        }

        public Menu (MenuItem x)
        {
            menuItems = new List<MenuItem>();
            this.AddItem(x);
        }

    }
}
