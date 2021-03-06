﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class UserInterface
    {
        public UserInterface()
        {

        }
        public void DisplayWelcome()
        {
            Console.WriteLine("\nWelcome to the Lemonade Stand Game!");
        }
        public static List<string> AddGameRule()
        {
            List<string> gameRules = new List<string>();
            gameRules.Add("\nGame rules:\n");
            gameRules.Add("\n[You decided to open a lemonade stand]");
            gameRules.Add("[Buy ingredients from the shop to create lemonade]");
            gameRules.Add("\n[Make the perfect lemonade recipe]");
            gameRules.Add("[Sell the lemonade]");
            gameRules.Add("\n[Attempt to make profit]");
            gameRules.Add("[Be aware that price, weather, and recipe can affect sales]");
            gameRules.Add("\n[Try to maintain enough inventory]");
            gameRules.Add("[Goodluck!]");
            gameRules.Add("\n\n[Press ENTER to continue.]");
            return gameRules;
        }
        public void DisplayRules()
        {
            foreach (string rule in AddGameRule())
            {
                Console.WriteLine(rule);
            }
        }
        public void MainMenu()
        {
            Console.WriteLine("\n\n1. [Start] \n\n2. [Rules] \n\n3. [Exit]");
        }
        public void StoreMenu()
        {
            Console.WriteLine("\nGame Store");
            Console.WriteLine("\n\nWe sell: \n\n1. [Lemons] \n\n2. [Sugar] \n\n3. [Ice] \n\n4. [Cups]");  
        }
    }
}
