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

            Menu.Add(new Pizza("Small Pizza", 9.99));
            Menu.Add(new Pizza("Medium Pizza", 11.99));
            Menu.Add(new Pizza("Large Pizza", 13.99));

            Menu.Add(new Sides("Salad", 6.99));
            Menu.Add(new Sides("Wings", 7.99));
            Menu.Add(new Sides("Bread", 6.99));
            Menu.Add(new Sides("Tostada", 5.99));

            Menu.Add(new Extras("2 Liter Soda", 1.99));
            Menu.Add(new Extras("Brownie", 2.99));
            Menu.Add(new Extras("Cookie", 1.99));

            for (int i = 0; i < MenuList.Count; i++)
            {
                Console.WriteLine(MenuList[i].ToString()); //print override info from UsedCar and Car
                //you can even write this without ToString Method, because the compiler will automatically do this for the printing of the object.
            }
            Console.WriteLine("Quit");

            Console.WriteLine("What would you like to order?");
            int CustomerChoice = int.Parse(Console.ReadLine());
            CustomerChoice = CustomerChoice - 1;
            if (CustomerChoice == MenuList.Count)
            {
                Console.WriteLine("Goodbye!");
            }

            else
            {
                //Console.WriteLine(InventoryList[CarChoice].Make);
                //validate input is only 1-6
                MenuList[CustomerChoice].PrintInfo(); //can also be done with ToString
            }

        }
    }
}
