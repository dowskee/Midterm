using System;
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
            //Present a menu to the user and let them choose an item (by number or letter)
            //Allow the user to choose a quantity for the item ordered
            //Give the user a line total (item price * quantity entered)
            
            Console.WriteLine("Welcome to Loco's Pizza! We hope you're hungry!");
            //display Menu Item, Price:?
            //List<Item> MenuList = new List<Item>(); //array of MenuList

            Console.WriteLine("Pizzas:");

            Console.WriteLine("1. Small Pizza", 9.99);
            Console.WriteLine("2. Medium Pizza", 11.99);
            Console.WriteLine("3. Large Pizza", 13.99);

            Console.WriteLine("Sides:");

            Console.WriteLine("4. Salad", 6.99);
            Console.WriteLine("5. Wings", 7.99);
            Console.WriteLine("6. Bread", 6.99);
            Console.WriteLine("7. Tostada", 5.99);

            Console.WriteLine("Extra Add-Ons:");

            Console.WriteLine("8. 2 Liter Soda", 1.99);
            Console.WriteLine("9. Brownie", 2.99);
            Console.WriteLine("10. Cookie", 1.99);

            //StreamWriter pizza = new StreamWriter("pizza.txt");
            //pizza.WriteLine("1. Small Pizza \t $9.99");
            //pizza.WriteLine("2. Medium Pizza \t $11.99");
            //pizza.WriteLine("3. Large Pizza \t $13.99");
            //pizza.WriteLine("4. Salad \t $6.99");
            //pizza.WriteLine("5. Wings \t $7.99");
            //pizza.WriteLine("6. Bread \t $6.99");
            //pizza.WriteLine("7. Tostada \t $5.99");
            //pizza.WriteLine("8. 2 Liter Soda \t $1.99");
            //pizza.WriteLine("9. Brownie \t $2.99");
            //pizza.WriteLine("10. Cookie \t $1.99");
            //pizza.Close();




            List<Item> PizzaList = new List<Item>();
            string str = Console.ReadLine();

            int UserChoice = int.Parse(Console.ReadLine());

            while (str != null)
            {
                string[] tempString = str.Split();
                PizzaList.Add(new Item(tempString[0],double.Parse(tempString[1])));
            }
            double sum = 0;
            if (UserChoice == 1 || UserChoice == 2 || UserChoice == 3 || UserChoice == 4 || UserChoice == 5 || UserChoice == 6 || UserChoice == 7 ||  UserChoice == 8 || UserChoice == 9 || UserChoice == 10)
            {
                for (int i = 0; i < PizzaList.Count; i++)
                {
                    sum+=PizzaList[i].Price;
                }
            }

            int UserOption = 0;
            while (true)
            {
                Console.WriteLine("Please choose an item:");
                Console.WriteLine("1. Order an item");
                Console.WriteLine("2. Remove and item");
                Console.WriteLine("3. Pay");
                Console.WriteLine("4. Exit");
                UserOption = int.Parse(Console.ReadLine());
                if (UserOption == 1)
                {
                    Console.WriteLine("Please enter an item");
                    string input = Console.ReadLine();
                    //PizzaList.Add(UserOption); FIX ME
                }
                else if (UserOption == 2)
                {
                    //remove an item from list
                }
                else if (UserOption == 3)
                {
                    for (int i = 0; i < PizzaList.Count; i++)
                    {
                        Console.WriteLine(PizzaList[i]);
                        //another nested if else for payment methods
                        //return generatePaymentMethod();
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
