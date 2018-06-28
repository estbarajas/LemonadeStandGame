using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Store
    {
        public Store()
        {

        }
        public void BuyLemons(Inventory inventory) 
        {
            Console.WriteLine("How many lemons would you like to purchase? (0.05 ea)");
            string userInput = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(userInput); i++)
            {
                Lemon lemon = new Lemon();
                inventory.lemons.Add(lemon);
            }
        }
        public void BuySugar(Inventory inventory)
        {
            Console.WriteLine("How many cups of sugar would you like to purchase? (0.09 ea)");
            string userInput = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(userInput); i++)
            {
                Sugar sugar = new Sugar();
                inventory.sugar.Add(sugar);
            }
        }
        public void BuyIce(Inventory inventory)
        {
            Console.WriteLine("How many ice cubes would you like to purchase? (0.01 ea)");
            string userInput = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(userInput); i++)
            {
                Ice ice = new Ice();
                inventory.ice.Add(ice);
            }
        }
        public void BuyCups(Inventory inventory)
        {
            Console.WriteLine("How many paper cups would you like to purchase? (0.03 ea)");
            string userInput = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(userInput); i++)
            {
                Cup cups = new Cup();
                inventory.cups.Add(cups);
            }
        }
    }
}
