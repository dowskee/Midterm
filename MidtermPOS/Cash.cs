using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPOS
{
    class Cash : Payment
    { 
        public override void generatePaymentMethod(double getpayment)

        {
            double change;

            Console.WriteLine("Please enter the amount tendered:");
            double payment = 0;

            while (!double.TryParse(Console.ReadLine(), out payment))
            {

                Console.WriteLine("Please use cash nothing else!");

            }

            change = payment - getpayment;

            Console.WriteLine($"\n\n Your change is ${Math.Round(change, 2)}");

        }

    }
}
