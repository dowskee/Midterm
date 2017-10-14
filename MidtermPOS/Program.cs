using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPOS
{
    class Program:Item
    {
        static void Main(string[] args)
        {
            //Present a menu to the user and let them choose an item (by number or letter)
            //Allow the user to choose a quantity for the item ordered
            //Give the user a line total (item price * quantity entered)
            
            Console.WriteLine("Welcome to Loco's Pizza! We hope you're hungry!");
            //display Menu Item, Price:?

            StreamWriter pizza = new StreamWriter("Menu.txt");
            pizza.WriteLine("1. Small Pizza".PadRight(20, ' ')+"\t"+"A small pizza w/ cheese and pepperoni".PadRight(35, ' ')+"\t"+"$9.99");
            pizza.WriteLine("2. Medium Pizza".PadRight(20, ' ')+"\t"+"A medium pizza w/ cheese and pepperoni".PadRight(10, ' ')+"\t"+"$11.99");
            pizza.WriteLine("3. Large Pizza".PadRight(20, ' ')+"\t"+"A large pizza w/ cheese and pepperoni".PadRight(35, ' ') +"\t"+"$13.99");
            pizza.WriteLine("4. Salad".PadRight(20, ' ')+"\t"+"A ceasar salad with crutons".PadRight(35, ' ')+"\t"+"$6.99");
            pizza.WriteLine("5. Tostada".PadRight(20, ' ')+"\t"+"Chef Mexico's famous Tostada".PadRight(35, ' ')+"\t"+"$5.99");
            pizza.WriteLine("6. Cheese Bread".PadRight(20, ' ')+"\t"+"Garlic bread with four cheese blend".PadRight(25, ' ')+"\t"+"$6.99");
            pizza.WriteLine("7. Wings".PadRight(20, ' ')+"\t"+"A dozen wings in our signature sauce".PadRight(35, ' ')+"\t"+"$7.99");
            pizza.WriteLine("8. 2 Liter Soda".PadRight(20, ' ')+"\t"+"2 Liter soda of your choosing".PadRight(35, ' ')+"\t"+"$1.99");
            pizza.WriteLine("9. Brownie".PadRight(20, ' ')+"\t"+"Brownie with chocolate frosting".PadRight(35, ' ')+"\t"+"$2.99");
            pizza.WriteLine("10. Cookie".PadRight(20, ' ')+"\t"+"Chocolate chip cookie".PadRight(35, ' ')+"\t"+"$1.99");
            pizza.WriteLine("11. Cinnamon Bread".PadRight(20, ' ')+"\t"+"Dessert bread with cinnamon".PadRight(35, ' ')+"\t"+"$4.99");
            pizza.WriteLine("12. Extra Toppings".PadRight(20, ' ')+"\t"+"Any extra topping of your choosing".PadRight(35, ' ')+"\t"+"$0.99");
            pizza.WriteLine("13. Exit Menu");
            pizza.Close();




            List<string> PizzaList = new List<string>();

            int UserOption = 0;

            //while (str != null)
            //{
            //    string[] tempString = str.Split();
            //    PizzaList.Add(new Item(tempString[0],double.Parse(tempString[1])));
            //}
            //double sum = 0;
            //if (UserChoice == 1 || UserChoice == 2 || UserChoice == 3 || UserChoice == 4 || UserChoice == 5 || UserChoice == 6 || UserChoice == 7 ||  UserChoice == 8 || UserChoice == 9 || UserChoice == 10)
            //{
            //    for (int i = 0; i < PizzaList.Count; i++)
            //    {
            //        sum+=PizzaList[i].Price;
            //    }
            //}
            while (true)
            {
                Console.WriteLine("Please choose an item:");
                Console.WriteLine("1. Order an item");
                Console.WriteLine("2. Remove an item");
                Console.WriteLine("3. Pay");
                Console.WriteLine("4. Exit");
                UserOption = int.Parse(Console.ReadLine());
                if (UserOption == 1)
                {
                    StreamReader MenuRead = new StreamReader("Menu.txt");
                    string MenuDisplay = MenuRead.ReadToEnd();
                    Console.WriteLine(MenuDisplay);

                    List<Item> MenuChoice = new List<Item>();
                    string MenuShow = MenuRead.ReadLine();
                    Console.WriteLine(MenuShow);

                    while(MenuShow != null)
                    {
                        string[] tempMenu = MenuShow.Split();
                        MenuChoice.Add(new Item(tempMenu[0], tempMenu[1], double.Parse(tempMenu[2])));
                        MenuShow = MenuRead.ReadLine();
                    }

                    foreach (Item Element in MenuChoice)
                    {
                        Console.WriteLine(Element.ToString());
                    }

                }
                else if (UserOption == 2)
                {
                    for (int i = 0; i < PizzaList.Count; i++)
                    {
                        Console.WriteLine(PizzaList[i]);
                        PizzaList.RemoveAt(1);// put the index
                        PizzaList.Remove("UserOption");
                        PizzaList.Clear();

                    }
                    //remove an item from list
                    
                }
                else if (UserOption == 3)
                {
                    for (int i = 0; i < PizzaList.Count; i++)
                    {
                        Console.WriteLine("How would you like to pay? Cash, Credit or Check?");
                        //Console.WriteLine(PizzaList[i]);
                        //another nested if else for payment methods
                        //return generatePaymentMethod();

                        Cash PaymentOption1 = new Cash();
                        Card PaymentOption2 = new Card();
                        Check PaymentOption3 = new Check();
                        string PaymentCash = PaymentOption1.generatePaymentMethod();
                        string PaymentCard = PaymentOption2.generatePaymentMethod();
                        string PaymentCheck = PaymentOption3.generatePaymentMethod();

                        string PaymentOption = Console.ReadLine();

                        if ((PaymentOption == "cash") || (PaymentOption == "Cash"))
                        {
                            Console.WriteLine(PaymentCash);
                        }

                        else if (PaymentOption == "Credit" || PaymentOption == "credit")
                        {
                            Console.WriteLine(PaymentCard);
                        }

                        else if (PaymentOption == "Check" || PaymentOption == "check")
                        {
                            Console.WriteLine(PaymentCheck);
                        }
                        
                        else
                        {
                            Console.WriteLine("Please enter a valid payment option. Cash, Credit or Check:");
                        }
                        
                    }
                }
                else
                {
                    Console.WriteLine("Thanks, see ya later!");
                    break;
                }
            }
            //for (int i = 0; i < ShoppingItems.Count; i++)
            //{
            //    Console.WriteLine(ShoppingItems[i]);
            //}
            //// ShoppingItems.RemoveAt(1);// put the index
            //// ShoppingItems.Remove("Milk");// mention the name of the item 
            //ShoppingItems.Clear();
        }
        //foreach (Item item in MenuList)
        //{
        //    item.PrintMenu(); //print override info from classes
        //    //you can even write this without ToString Method, because the compiler will automatically do this for the printing of the object.
        //}
        //Console.WriteLine("Exit Menu");


        //Console.WriteLine("What would you like to order?");
        //int CustomerChoice = int.Parse(Console.ReadLine());
        //CustomerChoice = CustomerChoice - 1;
        //if (CustomerChoice == MenuList.Count)
        //{
        //    Console.WriteLine("Goodbye!");
        //}

        //else
        //{
        //    decimal ItemSum = 0;
        //    foreach (Item item in MenuList)
        //    {
        //        ItemSum = ItemSum + item.Price[];
        //    }

        //    Console.WriteLine("Your total is:  $" + ItemSum.ToString("N2"));
        //}

        //Either through menu or separate question, allow them to re-display menu to complete purchase. 

        //give the subtotal, sales tax, and grand total
        //

        //public abstract void ProcessMethod( double Balance) 
        //{

        //}
        //Payment, then sub classes for cash, check, card. Payment should be abstract (template) and each class will return based on parameters
    }
}
