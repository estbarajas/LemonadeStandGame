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
                while(daysPlayedCounter <= 7)
                {        
                    Console.Clear(); //INVENTORY
                    DisplayInventory();
                    PressEnterToContinue();

                    if(daysPlayedCounter == 1)
                    {
                        Console.Clear(); //WEEKLYFORECAST
                        DisplayWeeklyWeather();
                        PressEnterToContinue();
                    }
                    Console.Clear(); //STORE
                    DisplayStore();
                    StoreLoop();
                    PressEnterToContinue();
                    Console.Clear(); //GAME
                    CustomerProfitPurchase();
                    Console.WriteLine("\nDay: #" + daysPlayedCounter);
                    Console.WriteLine("Current money total: " + player.wallet.money.ToString("N"));
                    Console.WriteLine("|Daily Profit: " + player.SetDailyIncome().ToString("N") + "|");
                    Console.WriteLine("|Total Profit: " + player.SetTotalIncome().ToString("N") + "|");
                    daysPlayedCounter++;

                    if(daysPlayedCounter == 8)
                    {
                        Console.WriteLine("\n\n-----GAME OVER!-----");
                        PressEnterToContinue();
                    }
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
        }
        public void StoreLoop()
        {
            String option;
            do
            {
                Console.WriteLine("\nWhich would you like to purchase? Otherwise type 0 to finish buying.");
                option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("\nExiting Store...");
                        break;
                    case "1":
                        store.BuyLemons(player.inventory, player.wallet);
                        break;
                    case "2":
                        store.BuySugar(player.inventory, player.wallet);
                        break;
                    case "3":
                        store.BuyIce(player.inventory, player.wallet);
                        break;
                    case "4":
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
            Console.WriteLine("\nGet your lemonade!");
            Console.WriteLine("Lemonade price: 35 cents");
            Console.WriteLine("\nWeather condition: " + day.weather.weatherCondition); 
            Console.WriteLine("Weather temperature: " + day.weather.GetTemperature());   
            day.DeleteCustomers(); 
            day.CreateCustomers(); 
            day.DisplayCustomerListCount(); 
            day.DisplayPurchase(player);    
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
