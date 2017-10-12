using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPOS
{
    class Sides
    {
        #region Variables
        private string sideorder;
        private double price;
        #endregion

        #region Properties
        public string SideOrder
        {
            set { sideorder = value; }
            get { return sideorder; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
        #endregion

        #region Constructors

        public Sides()
        {
            sideorder = "";
            price = 0;
        }

        public Sides(string sdordr, double prz)
        {
            SideOrder = sdordr;
            Price = prz;
        }

        #endregion

        public virtual void PrintMenu()
        {
            Console.WriteLine(SideOrder + "$" + Price.ToString("N2"));
        }
    }
}
