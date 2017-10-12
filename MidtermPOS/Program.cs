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



            List<Menu> MenuList = new List<Menu>(); //array of MenuList
            //Make an abstract class for Menu that is an empty template?
            //or an array

            //Pizzas
            Menu.Add(new Item("Small Pizza", 9.99));
            Menu.Add(new Item("Medium Pizza", 11.99));
            Menu.Add(new Item("Large Pizza", 13.99));

            //Sides
            Menu.Add(new Item("Salad", 6.99));
            Menu.Add(new Item("Wings", 7.99));
            Menu.Add(new Item("Bread", 6.99));
            Menu.Add(new Item("Tostada", 5.99));

            //Extras
            Menu.Add(new Item("2 Liter Soda", 1.99));
            Menu.Add(new Item("Brownie", 2.99));
            Menu.Add(new Item("Cookie", 1.99));

            for (int i = 0; i < MenuList.Count; i++)
            {
                Console.WriteLine(MenuList[i].ToString()); //print override info from classes
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
                
                //validate input is only 1-13
                MenuList[CustomerChoice].PrintInfo(); //can also be done with ToString
            }



            //public abstract void ProcessMethod( double Balance) 
            //{

            //}
            //Payment, then sub classes for cash, check, card. Payment should be abstract (template) and each class will return based on parameters
        }
    }
}
