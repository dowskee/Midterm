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
           int ScanCheckNumber = int.Parse(Console.ReadLine());
            if (ScanCheckNumber != 9)
            {
                Console.WriteLine("Please enter a valid check number. A check number will have 9 digits:");
            }
            else
            {
                while (!int.TryParse(Console.ReadLine(), out ScanCheckNumber))
                {
                    Console.WriteLine("Please enter a valid check number");
                    ScanCheckNumber = int.Parse(Console.ReadLine());
                }
                //return ScanCheckNumber?
            }

            return generatePaymentMethod();
        }
    }
}
