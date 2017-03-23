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
        private double price;
        private string description;
        private string category;

        public string Name
        {
            private get { return name; }
            set { name = value; }
        }        

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public MenuItem(string passedname)
        {
            name = passedname

        }

    }
    public class Menu
    {
        private List<MenuItem> menu = new List<MenuItem>();
        public List<MenuItem> MenuItem { get { return menu; } }




    }
}
