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
                //while()
                //{
                    //only call functions here xD
                //}
                Console.Clear();
                userInterface.StoreMenu();
                //store.BuyLemons(player.inventory);
                //store.BuyLemons(player.inventory);
                //player.inventory.DisplayLemonAmmount();
                //userInterface.StoreMenu();
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
        public void ExitGame()
        {
            Environment.Exit(0);
        }
    }
}
