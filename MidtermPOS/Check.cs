using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPOS
{
    class Check : Payment
    {
        public override void generatePaymentMethod(double getpayment)
        {
            Console.WriteLine("Please enter the check number");

            GetCheckNum();
            Console.WriteLine($"\n\n Thank you. You wrote a check for {Math.Round(getpayment, 2)}. Your check has been processed. Have a great day!");

        }

        public static string GetCheckNum()
        {
            string CheckNumValid = Console.ReadLine();

            if (CheckNumValid.Length != 9) //checks for length of 9
            {
                Console.WriteLine("Please enter a valid check number. A check number will have 9 digits.");
                CheckNumValid = Console.ReadLine();

            }

            return CheckNumValid;

            
        }
    }
}
