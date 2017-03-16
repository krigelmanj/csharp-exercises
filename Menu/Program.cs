using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restraurant
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
    public class MenuItem
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double price;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

    }
    public class Menu
    {
        private List<MenuItem> menu = new List<MenuItem>();
        public List<MenuItem> MenuItem { get { return menu; } }




    }
}
