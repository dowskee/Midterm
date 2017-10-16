﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPOS
{
    class Program 
    {
        static void Main(string[] args)
        {


            StreamReader rd1 = new StreamReader("Menu.txt");
            string str1 = rd1.ReadToEnd();
            Console.WriteLine(str1);

            Console.WriteLine("\n \n");

            List<Item> menuItems = new List<Item>();

            List<Item> Cart = new List<Item>();

            StreamReader rd = new StreamReader("Menu.txt");
            string Menu = "";
            while (!rd.EndOfStream)
            {
                string str = rd.ReadLine();
                var strArray = str.Split(',');

                Item newItem = new Item();
                newItem.ItemNumber = int.Parse(strArray[0]);
                newItem.Name = strArray[1];
                newItem.Description = strArray[2];
                newItem.Price = double.Parse(strArray[3].Remove(0, 1));
                Menu = Menu + str+"\n";
                menuItems.Add(newItem);
            }

            
            //int usernumber = int.Parse(Console.ReadLine());

            //for (int i = 0; i < menuItems.Count; i++)
            //{
            //    if (usernumber == menuItems[i].ItemNumber)
            //    {
            //        Console.WriteLine(menuItems[i].Name + " " + menuItems[i].Description + " " + menuItems[i].Price);
            //    }
            //}

            

            int userOption = 0;
            while (true)
            {
                Console.WriteLine("Please choose an option");
                Console.WriteLine("1. Add an item");
           
                Console.WriteLine("2. Checkout and Pay");
                Console.WriteLine("3. Exit");
                userOption = int.Parse(Console.ReadLine());
              
                   

                    if (userOption == 1)
                    {
                       
                        Console.WriteLine("Please choose an item from the list");
                        Console.WriteLine(Menu);
                       int menuSelection = int.Parse(Console.ReadLine());
                        Cart.Add(menuItems[menuSelection - 1]);
                    Console.WriteLine("You added "+ menuItems[menuSelection - 1].Name);
                        
                    }



                   
                    else if (userOption == 2)
                    {

 double getpayment = 0;
                        double subtotal = 0;
                        double grandtotal = 0;

                    for (int i = 0; i < Cart.Count; i++)
                    {
                       
                        //double price = PrintMenu(double.Parse(Price.ToString()));
                        //subtotal = PrintMenu(Price.ToString()) * quantity;

                        subtotal = subtotal +Cart[i].Price; //split?
                    }
                            grandtotal = subtotal * 1.06;

                           // Console.WriteLine(menuItems[i]);
                            Console.WriteLine($"Your subtotal is {subtotal}");
                            Console.WriteLine($"Your grand total with tax is {grandtotal}");
                            //sum total and call
                            Console.WriteLine("How would you like to pay? Cash, Credit or Check?");

                            string PaymentOption = Console.ReadLine().ToLower();

                            if ((PaymentOption == "cash") || (PaymentOption == "Cash"))
                            {
                                Cash PaymentOptionCash = new Cash();
                                PaymentOptionCash.generatePaymentMethod(getpayment);
                            }

                            else if (PaymentOption == "Credit" || PaymentOption == "credit")
                            {
                                Card PaymentOptionCard = new Card();
                                PaymentOptionCard.generatePaymentMethod(getpayment);
                            }

                            else if (PaymentOption == "Check" || PaymentOption == "check")
                            {
                                Check PaymentOptionCheck = new Check();
                                PaymentOptionCheck.generatePaymentMethod(getpayment);
                            }

                            else if (PaymentOption != "Check" || PaymentOption != "Credit" || PaymentOption != "Cash")
                            {
                                Console.WriteLine("Please enter a valid payment option. Cash, Credit or Check:");
                            }
                            else
                            {
                                int id = 0;

                                while (!int.TryParse(Console.ReadLine(), out id))
                                {
                                    Console.WriteLine("Nice try.");
                                    //return PaymentValid?
                                }
                            }
                        }

                    

                    else
                    {
                        Console.WriteLine("Thanks, see you later");
                        break;
                    }


                
            }




        }
    }
}
