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
        public int daysPlayedCounter;
        public Game()
        {
            userInterface = new UserInterface();
            store = new Store();
            player = new Player();
            day = new Day();
            daysPlayedCounter = 1;
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
                while(daysPlayedCounter <= 7)
                {        
                    Console.Clear(); //INVENTORY
                    DisplayInventory();
                    PressEnterToContinue();
                    
                    //Console.Clear(); //WEEKLYFORECAST
                    //DisplayWeeklyWeather();
                    //PressEnterToContinue();

                    Console.Clear(); //STORE
                    DisplayStore();
                    StoreLoop();
                    PressEnterToContinue();
                    /*
                    Console.Clear(); //RECIPE
                    DisplayRecipe();
                    PressEnterToContinue();

                    Console.Clear(); //INVENTORY
                    DisplayInventory();
                    PressEnterToContinue();

                    Console.Clear(); //GAME
                    Console.WriteLine("\t\nTHE GAME IS RUNNING HERE");
                    PressEnterToContinue();
                    */
                    //Console.Clear(); //INVENTORY
                    //DisplayInventory();
                    //player.wallet.MoneyToSpend();
                    //.WriteLine("Day: " + daysPlayedCounter);
                    //daysPlayedCounter++;                  
                    //Console.ReadLine();
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
            //store.BuySugar(player.inventory);
            //store.BuyIce(player.inventory);
            //store.BuyCups(player.inventory);
        }
        public void StoreLoop()
        {
            String option;
            do
            {
                //menu();
                Console.WriteLine("Buy 50 more lemonksXD enter 1");
                option = Console.ReadLine();
                switch (Convert.ToInt32(option))
                {
                    case 0:
                        Console.WriteLine("\nExiting...");
                        break;
                    case 1:
                        Console.WriteLine("\nBuying lemons");
                        store.BuyLemons(player.inventory);
                        break;
                    case 2:
                        Console.WriteLine("\nBuying sugar");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            } while ((Convert.ToInt32(option)) != 0);
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
