using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPOS
{
    class Extras
    {
        #region Variables
        private string extrachoice;
        private double price;
        #endregion

        #region Properties
        public string ExtraChoice
        {
            set { extrachoice = value; }
            get { return extrachoice; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }

        #endregion

        #region Constructors

        public Extras()
        {
            extrachoice = "";
            price = 0;
        }

        public Extras(string xtrachoice, double prz)
        {
            ExtraChoice = xtrachoice;
            Price = prz;
        }

        #endregion

        public virtual void PrintMenu()
        {
            Console.WriteLine(ExtraChoice + "$" + Price.ToString("N2"));
        }
    }
}
