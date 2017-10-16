using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPOS
{
    class Card : Payment
    {
        private string cardnumber;
        private string ccv;
        private DateTime expdate;

        public string CardNumber
        {
            set { cardnumber = value; }

            get { return cardnumber; }


        }


        public string Ccv
        {
            set { ccv = value; }
            get { return ccv; }


        }

        public DateTime Expdate
        {

            set { expdate = value; }
            get { return expdate; }

        }


        public Card()
        {
            Expdate = DateTime.Now;
            Ccv = " ";
            CardNumber = " ";
        }


        public Card(string ccvnum, DateTime expi, string cnumber)
        {
            CardNumber = cnumber;
            Expdate = expi;
            Ccv = ccvnum;

        }

        public static string GetValidCVV()
        {
            string cvv = Console.ReadLine();

            if (cvv.Length != 3)
            {
                Console.WriteLine("Please enter a valid CVV!");
                cvv = Console.ReadLine();
            }

            return cvv;

        }

        public static string GetvalidCardnum()
        {
            string Creditnumber = Console.ReadLine();

            if (Creditnumber.Length != 16)
            {
                Console.WriteLine("Please enter a valid credit card number");
                Creditnumber = Console.ReadLine();

            }

            return Creditnumber;

        }

        bool CheckValidDateTime(int year, int month, int day)
        {
            bool check = false;
            while (check == false)
                if (year <= DateTime.MaxValue.Year && year >= DateTime.MinValue.Year)
                {
                    if (month >= 1 && month <= 12)
                    {
                        if (DateTime.DaysInMonth(year, month) >= day && day >= 1)
                            check = true;
                    }
                }

            return check;

        }

        public override void generatePaymentMethod(double getpayment)
        {
            Console.WriteLine("Please enter your card number:");
            GetvalidCardnum(); //calls each validation method
            Console.WriteLine("Please enter your card's CVV:");
            GetValidCVV();
            Console.WriteLine("Please enter your card's expiration date (MM/DD/YYYY):");

        }
    }

}
