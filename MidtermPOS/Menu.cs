using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPOS
{
    abstract class Menu
    {
        private string name;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public Menu()
        {
            name = "";
        }

        public Menu(string nm)
        {
            Name = nm;
        }

        public abstract string generatename();
    }
}
