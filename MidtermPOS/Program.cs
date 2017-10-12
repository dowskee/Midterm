using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermPOS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Loco's Pizza! We hope you're hungry!");

            List<Item> MenuList = new List<Item>(); //array of MenuList

            //Console.WriteLine("Pizzas:");

            MenuList.Add(new Item("Small Pizza", 9.99));
            MenuList.Add(new Item("Medium Pizza", 11.99));
            MenuList.Add(new Item("Large Pizza", 13.99));

            //Console.WriteLine("Sides:");

            MenuList.Add(new Item("Salad", 6.99));
            MenuList.Add(new Item("Wings", 7.99));
            MenuList.Add(new Item("Bread", 6.99));
            MenuList.Add(new Item("Tostada", 5.99));

            //Console.WriteLine("Extra Add-Ons:");

            MenuList.Add(new Item("2 Liter Soda", 1.99));
            MenuList.Add(new Item("Brownie", 2.99));
            MenuList.Add(new Item("Cookie", 1.99));

            foreach (Item item in MenuList)
            {
                item.PrintMenu(); //print override info from classes
                //you can even write this without ToString Method, because the compiler will automatically do this for the printing of the object.
            }
            Console.WriteLine("Exit Menu");

            Console.WriteLine("What would you like to order?");
            int CustomerChoice = int.Parse(Console.ReadLine());
            CustomerChoice = CustomerChoice - 1;
            if (CustomerChoice == MenuList.Count)
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                decimal ItemSum = 0;
                for (int i = 0; i < MenuList.Count; i++)
                {
                    ItemSum = ItemSum + MenuList.Count(); //the element is the shape itself. This is calling the area of each element in each shape.
                }

                Console.WriteLine("Your total is: " + ItemSum);
            }



            //public abstract void ProcessMethod( double Balance) 
            //{

            //}
            //Payment, then sub classes for cash, check, card. Payment should be abstract (template) and each class will return based on parameters
        }
    }
}
