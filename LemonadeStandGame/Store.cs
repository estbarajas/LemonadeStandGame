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
        public void BuyLemons(Inventory inventory, Wallet wallet)
        {
            Console.WriteLine("How many lemons would you like to purchase? (0.05 ea)");
            string userInput = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(userInput); i++)
            {
                Lemon lemon = new Lemon();
                inventory.lemons.Add(lemon);
            }
            wallet.RemoveMoneyAmmount(Convert.ToInt32(userInput), inventory.lemons.ElementAtOrDefault(0).price);
        }
        public void BuySugar(Inventory inventory, Wallet wallet)
        {
            Console.WriteLine("How many cups of sugar would you like to purchase? (0.09 ea)");
            string userInput = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(userInput); i++)
            {
                Sugar sugar = new Sugar();
                inventory.sugar.Add(sugar);
            }
            wallet.RemoveMoneyAmmount(Convert.ToInt32(userInput), inventory.sugar.ElementAtOrDefault(0).price);
        }
        public void BuyIce(Inventory inventory, Wallet wallet)
        {
            Console.WriteLine("How many ice cubes would you like to purchase? (0.01 ea)");
            string userInput = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(userInput); i++)
            {
                Ice ice = new Ice();
                inventory.ice.Add(ice);
            }
            wallet.RemoveMoneyAmmount(Convert.ToInt32(userInput), inventory.ice.ElementAtOrDefault(0).price);
        }
        public void BuyCups(Inventory inventory, Wallet wallet)
        {
            Console.WriteLine("How many paper cups would you like to purchase? (0.03 ea)");
            string userInput = Console.ReadLine();
            for (int i = 0; i < Convert.ToInt32(userInput); i++)
            {
                Cup cups = new Cup();
                inventory.cups.Add(cups);
            }
            wallet.RemoveMoneyAmmount(Convert.ToInt32(userInput), inventory.cups.ElementAtOrDefault(0).price);
        }
    }
}
