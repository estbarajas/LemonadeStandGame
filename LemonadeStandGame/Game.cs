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
        public Day day;
        public string userInput;
        public Game()
        {
            userInterface = new UserInterface();
            store = new Store();
            player = new Player();
            day = new Day();
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
                    Console.Clear(); //INVENTORY
                    DisplayInventory();
                    PressEnterToContinue();

                    Console.Clear(); //WEEKLYFORECAST
                    DisplayWeeklyWeather();
                    PressEnterToContinue();

                    Console.Clear(); //STORE
                    DisplayStore();
                    PressEnterToContinue();

                    Console.Clear(); //RECIPE
                    DisplayRecipe();
                    PressEnterToContinue();

                    Console.Clear(); //INVENTORY
                    DisplayInventory();
                    PressEnterToContinue();

                    Console.Clear(); //GAME
                    Console.WriteLine("\t\nTHE GAME IS RUNNING HERE");
                    PressEnterToContinue();
                }     
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
            store.BuyLemons(player.inventory);
            store.BuySugar(player.inventory);
            store.BuyIce(player.inventory);
            store.BuyCups(player.inventory);
        }
        public void DisplayRecipe()
        {
            Console.WriteLine("\nRecipe:\n");
            player.recipe.UseLemonAmmount(player.inventory);
            player.recipe.UseIceAmmount(player.inventory);
            player.recipe.UseSugarAmmount(player.inventory);
            player.recipe.UseCupAmmount(player.inventory);
        }
        public void DisplayWeeklyWeather()
        {
            day.weather.GetWeeklyForecast();
        }
        public void ExitGame()
        {
            Environment.Exit(0);
        }
        public void PressEnterToContinue()
        {
            Console.WriteLine("\n\nPress |ENTER| to continue.");
            Console.ReadLine();
        }
    }
}
