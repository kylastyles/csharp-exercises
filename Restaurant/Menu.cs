﻿using System;
using System.Collections.Generic;

namespace Restaurant
{
    public class Menu
    {
        private List<MenuItem> appetizers;
        public List<MenuItem> Appetizers
        {
            get { return appetizers; }
            set => appetizers = value;
        }

        private List<MenuItem> entrees;
        public List<MenuItem> Entrees
        {
            get { return entrees; }
            set => entrees = value;
        }

        private List<MenuItem> desserts;
        public List<MenuItem> Desserts
        {
            get { return desserts; }
            set => desserts = value;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string lastUpdate;
        public string LastUpdate
        {
            get { return lastUpdate; }
            set { lastUpdate = value; }
        }


        //public methods

        public void AddItem (MenuItem newItem)
        {
            foreach (MenuItem oldItem in Appetizers)
            {
                oldItem.NewItem = false;
            }
            foreach (MenuItem oldItem in Entrees)
            {
                oldItem.NewItem = false;
            }
            foreach (MenuItem oldItem in Desserts)
            {
                oldItem.NewItem = false;
            }

            if (newItem.Category == "Appetizer")
            {
                Appetizers.Add(newItem);
            } else if (newItem.Category == "Entree")
            {
                Entrees.Add(newItem);
            } else if (newItem.Category == "Dessert")
            {
                Desserts.Add(newItem);
            } else
            {
                Console.WriteLine("AddItem Failed: unknown category");
            }
            this.LastUpdate = DateTime.Now.ToString();
        }

        public void RemoveItem (MenuItem x)
        {
            if (x.Category == "Appetizer")
            {
                Appetizers.Remove(x);
            }
            else if (x.Category == "Entree")
            {
                Entrees.Remove(x);
            }
            else if (x.Category == "Dessert")
            {
                Desserts.Remove(x);
            }
            else
            {
                Console.WriteLine("RemoveItem Failed: unknown category");
            }
            this.LastUpdate = DateTime.Now.ToString();
        }

        public override string ToString ()
        {
            string menuprint = "";
            menuprint += String.Format("Welcome to {0}!\n", this.Name);
            try
            {
                menuprint += "\nAPPETIZERS\n**********\n";
                foreach (MenuItem x in Appetizers)
                {
                    if (x.NewItem == true)
                    {
                        menuprint += "NEW! ";
                    }
                    menuprint += x.ToString() + "\n";
                }
                menuprint += "\nENTREES\n*******\n";
                foreach (MenuItem x in Entrees)
                {
                    if (x.NewItem == true)
                    {
                        menuprint += "NEW! ";
                    }
                    menuprint += x.ToString() + "\n";
                }
                menuprint += "\nDESSERTS\n********\n";
                foreach (MenuItem x in Desserts)
                {
                    if (x.NewItem == true)
                    {
                        menuprint += "NEW! ";
                    }
                    menuprint += x.ToString() + "\n";
                }
                menuprint += String.Format("\nMenu last updated: {0:D}\n~Bon Appetit~", this.LastUpdate);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Menu is empty");
            }
            return menuprint;
        }

    //constructors, overloaded
        public Menu ()
        {
            Appetizers = new List<MenuItem>();
            Entrees = new List<MenuItem>();
            Desserts = new List<MenuItem>();
        }

        public Menu (string name)
        {
            Name = name;

            Appetizers = new List<MenuItem>();
            Entrees = new List<MenuItem>();
            Desserts = new List<MenuItem>();
        }

        public Menu (MenuItem x)
        {
            Appetizers = new List<MenuItem>();
            Entrees = new List<MenuItem>();
            Desserts = new List<MenuItem>();

            this.AddItem(x);
        }

        public Menu (params MenuItem[] items)
        {
            Appetizers = new List<MenuItem>();
            Entrees = new List<MenuItem>();
            Desserts = new List<MenuItem>();

            foreach (MenuItem item in items)
            {
                this.AddItem(item);
            }
        }

    }
}
