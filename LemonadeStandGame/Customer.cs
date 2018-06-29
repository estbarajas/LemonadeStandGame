using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Customer
    {
        
        public string name;
        public int percentChanceToBuy;
        public Customer()
        {
            name = "remove";
            //percentChanceToBuy = randomNumber.Next(40, 61);
            
        }
        public void ChanceOfPurchase(Weather weather, Random randomNumber)
        {
            Console.WriteLine("The temperature is: " + weather.GetTemperature());
            if (weather.temperature > 80)
            {
                percentChanceToBuy = randomNumber.Next(45, 66); 
                Console.WriteLine("25% failure rate");
            }
            else if (weather.temperature > 70)
            {
                percentChanceToBuy = randomNumber.Next(40, 66); 
                Console.WriteLine("40% failure rate");
            }
            else if (weather.temperature < 70)
            {
                percentChanceToBuy = randomNumber.Next(35, 66); 
                Console.WriteLine("50% failure rate");
            }
        }
    }
}
