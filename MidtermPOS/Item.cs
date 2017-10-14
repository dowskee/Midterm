using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPOS
{
    class Item
    {
        //Menu class with the name, category, description, and price for each item 
        #region Variables
        private string itemlist;
        private string description;
        private double price;
        #endregion

        #region Properties
        public string MenuItem
        {
            set { itemlist = value; }
            get { return itemlist; }
        }

        public string Description
        {
            set { description = value; }
            get { return description; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }
        #endregion

        #region Constructors

        public Item()
        {
            itemlist = "";
            description = "";
            price = 0;
        }

        public Item(string itmlst, string desc, double prz)
        {
            itemlist = itmlst;
            description = desc;
            Price = prz;
        }

        #endregion
        //needs name, price, description and category for each item
        public virtual void PrintMenu()
        {
            Console.WriteLine(MenuItem.PadRight(20, ' ') + "\t" + Description.PadRight(20, ' ') + "$" + Price.ToString("N2"));
        }
    }
}
