using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Restaurant
{
    public class MenuItem : Menu
    {
        public static int nextID = 1;

    //private
        private int id;
        private string name;
        private string description;
        private double price;
        private string category;
        private string createdOn = DateTime.Now.ToString();

        private string[] categories = new string[]
            { "Appetizer", "Entree", "Dessert" };

    //public
        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }

        public string Category
        {
            get => category;
            set
            {
                if (!categories.Contains(value))
                    throw new Exception("Invalid category");
                else category = value;
            }
        }

    //Constructors, overloaded
        public MenuItem (string name, string description, double price, string category)
        {

            id = ++nextID;
            Name = name;
            Description = description;
            Price = price;
            Category = category;

        }

        public MenuItem ()
        {
            id = ++nextID;
        }



        public DateTime currentTime;

        public bool NewCheck (DateTime createdDate)
        {
            TimeSpan threeMonths = new TimeSpan(2160, 0, 0);
            if (currentTime.Subtract(createdDate) < threeMonths)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Equals (MenuItem x)
        {
            if (x == this)
            {
                return true;
            }
            else if (x == null)
            {
                return false;
            }
            else if (x.GetType() != GetType())
            {
                return false;
            }

            MenuItem menuObj = x as MenuItem;
            return id == menuObj.id;
        }

        public override string ToString ()
        {
            return String.Format("{0}; {1}; {2:C}", Name, Description, Price);
        }
    }
}
