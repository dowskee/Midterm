using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPOS
{
    class Pizza
    {
        //Menu class with the name, category, description, and price for each item 
        #region Variables
        private string pizza;
        private double price;
        #endregion

        #region Properties
        public string PizzaSize
        {
            set { pizza = value; }
            get { return pizza; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }
        #endregion

        #region Constructors

        public Pizza()
        {
            pizza = "";
            price = 0;
        }

        public Pizza(string pitsa, double prz)
        {
            PizzaSize = pitsa;
            Price = prz;
        }

        #endregion

        public virtual void PrintMenu()
        {
            Console.WriteLine(PizzaSize + "$" + Price.ToString("N2"));
        }
    }
}
