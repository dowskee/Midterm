using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPOS
{
    public class Item
    {
        //Menu class with the name, category, description, and price for each item 
        #region Variables
        private int itemNumber;
        private string name;
        private string category;
        private string description;
        private double price;
        #endregion

        #region Properties
        public int ItemNumber
        {
            set { itemNumber = value; }
            get { return itemNumber; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public string Category
        {
            set { category = value; }
            get { return category; }
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
    }
}
