using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPOS
{
    class Cash : Payment
    {
        public override string generatePaymentMethod()

        {
            decimal AmountOfCash = decimal.Parse(Console.ReadLine());
            decimal AmountOfChange;

            //mountOfChange = AmountOfCash - ItemSum

            //need validation
        
            return generatePaymentMethod();
        }

    }
}
