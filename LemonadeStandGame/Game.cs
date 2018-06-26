using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Game
    {
        public UserInterface userInterface;
        public Store store;
        public Player player;
        public string userInput;
        public Game()
        {
            userInterface = new UserInterface();
            store = new Store();
            player = new Player();
        }
        public void ExecuteGame()
        {       
            userInterface.DisplayWelcome();
            userInterface.MainMenu();
            GamePlay();
        }
        public void GamePlay()
        {
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                //while loop
                while(true)
                {
                    Console.Clear();
                    DisplayInventory();
                    PressEnterToContinue();
                    Console.ReadLine();
                    Console.Clear();
                    DisplayStore();
                    Console.ReadLine();
                }
                //Console.Clear();
                //DisplayInventory();   
            }
            else if (userInput == "2")
            {
                Console.Clear();
                userInterface.DisplayRules();
                Console.ReadLine();
                Console.Clear();
                ExecuteGame();
            }
            else if (userInput == "3")
            {
                ExitGame();
            }
            else
            {
                Console.WriteLine("\nInvalid input! \n\nNote: Please enter a valid menu option. \nPress the ENTER key to try again.");
                Console.ReadLine();
                Console.Clear();
                ExecuteGame();
            }
        }
        public void DisplayInventory()
        {
            Console.WriteLine("\nInventory:\n");
            player.inventory.DisplayLemonAmmount();
            player.inventory.DisplaySugarAmmount();
            player.inventory.DisplayIceAmmount();
            player.inventory.DisplayCupAmmount();
        }
        public void DisplayStore()
        {
            userInterface.StoreMenu();
        }
        public void ExitGame()
        {
            Environment.Exit(0);
        }
        public void PressEnterToContinue()
        {
            Console.WriteLine("\nPress |ENTER| to continue.");
        }
    }
}
