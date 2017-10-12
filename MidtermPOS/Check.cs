using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPOS
{
    class Check : Payment
    {
        public override string generatePaymentMethod()
        {
            string ScanCheckNumber = Console.ReadLine();
            //need validation
            return generatePaymentMethod();
        }
    }
}
