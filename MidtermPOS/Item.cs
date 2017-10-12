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
        private double price;
        #endregion

        #region Properties
        public string MenuItem
        {
            set { itemlist = value; }
            get { return itemlist; }
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
            price = 0;
        }

        public Item(string itmlst, double prz)
        {
            itemlist = itmlst;
            Price = prz;
        }

        #endregion

        public virtual void PrintMenu()
        {
            Console.WriteLine(MenuItem + "$" + Price.ToString("N2"));
        }
    }
}
