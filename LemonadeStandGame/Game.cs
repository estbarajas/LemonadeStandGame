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
        Random randomNumber2;
        public Game()
        {
            randomNumber2 = new Random();
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

                    Console.Clear();
                    CustomerProfitPurchase();
                    PressEnterToContinue();
                    //Console.Clear(); //WEEKLYFORECAST
                    //DisplayWeeklyWeather();
                    //PressEnterToContinue();
                    /* **********************************
                    Console.Clear(); //STORE
                    DisplayStore();
                    StoreLoop();
                    PressEnterToContinue();

                    Console.Clear();
                    Console.WriteLine("\nThe daily income is: " + player.SetIncome());
                    PressEnterToContinue();
                    *////////////////////////////*****************




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
            //store.BuyLemons(player.inventory);
            //store.BuySugar(player.inventory);
            //store.BuyIce(player.inventory);
            //store.BuyCups(player.inventory);
        }
        public void StoreLoop()
        {
            String option;
            do
            {
                //Console.WriteLine("Buy 50 more lemonksXD enter 1");
                Console.WriteLine("\nWhich would you like to purchase? Otherwise type 0 to finish buying.");
                option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("\nExiting Store...");
                        break;
                    case "1":
                        //Console.WriteLine("\nBuying lemons");
                        store.BuyLemons(player.inventory, player.wallet);
                        break;
                    case "2":
                        //Console.WriteLine("\nBuying sugar");
                        store.BuySugar(player.inventory, player.wallet);
                        break;
                    case "3":
                        //Console.WriteLine("\nBuying ice cubes");
                        store.BuyIce(player.inventory, player.wallet);
                        break;
                    case "4":
                        //Console.WriteLine("\nBuying cups");
                        store.BuyCups(player.inventory, player.wallet);
                        break;
                    default:
                        Console.WriteLine("\nInvalid option.");
                        break;
                }
            } while (option != "0");
        }
        public void DisplayRecipe()
        {
            Console.WriteLine("\nRecipe:\n");
            player.recipe.UseLemonAmmount(player.inventory);
            player.recipe.UseIceAmmount(player.inventory);
            player.recipe.UseSugarAmmount(player.inventory);
            player.recipe.UseCupAmmount(player.inventory);
        }
        public void CustomerProfitPurchase()
        {
            Console.WriteLine(day.weather.weatherCondition);
            day.DeleteCustomers();
            day.CreateCustomers();
            day.DisplayCustomerListCount();
            for (int i = 0; i < day.customers.Count; i++)
            {
                Console.WriteLine(i);
            }
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
