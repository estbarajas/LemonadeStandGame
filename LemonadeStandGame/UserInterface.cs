using System;
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
            Console.WriteLine("\tWelcome to the Lemonade Stand Game!");
        }
        public static List<string> AddGameRule()
        {
            List<string> gameRules = new List<string>();
            gameRules.Add("\nGame rules:");
            gameRules.Add("\n[You decided to open a lemonade stand]");
            gameRules.Add("[Buy ingredients from the shop to create lemonade]");
            gameRules.Add("\n[Make the perfect lemonade recipe]");
            gameRules.Add("[Set a price to sell the lemonade]");
            gameRules.Add("\n[Attempt to satisfy customers]");
            gameRules.Add("[Be aware that price, weather, and recipe can affect sales]");
            gameRules.Add("\n[Try to maintain customer satisfaction up]");
            gameRules.Add("[Goodluck!]");
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

        }
    }
}
