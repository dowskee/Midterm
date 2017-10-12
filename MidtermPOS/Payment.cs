using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPOS
{
    abstract class Payment
    {
        #region Variables
        private string typeOfPayment;
        #endregion

        #region Properties
        // properties
        public string TypeOfPayment
        {
            set { typeOfPayment = value; }
            get { return typeOfPayment; }
        }

        #endregion

        #region Constructor
        //constructor
        public Payment()
        {
            TypeOfPayment = "";
        }
        public Payment(string typeofp)
        {
            TypeOfPayment = typeofp;
        }

        #endregion
        public abstract string generatePaymentMethod();
    }
}
