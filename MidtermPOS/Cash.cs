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

                double payment = double.Parse(Console.ReadLine());

                change = payment - getpayment;

                Console.WriteLine($"Your change is {change}"); //N2 later

                // decimal AmountOfChange;

                //mountOfChange = AmountOfCash - ItemSum

                //need validation

            }

        

    }
}
