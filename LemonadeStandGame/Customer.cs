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
        public Customer(Random randomNumber)
        {
            //percentChanceToBuy = randomNumber.Next(40, 61);
        }
        public void CheckIfBoughtLemonade(Weather weather, Random randomNumber)
        {
            if (weather.temperature > 80)
            {
                percentChanceToBuy = randomNumber.Next(45, 66); //5:15 25% failure rate
            }
            else if (weather.temperature > 70)
            {
                percentChanceToBuy = randomNumber.Next(40, 66); //10:15 40% failure rate
            }
            else if (weather.temperature < 70)
            {
                percentChanceToBuy = randomNumber.Next(35, 66); //15:15 50% failure rate
            }
        }
    }
}
