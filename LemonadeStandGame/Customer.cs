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
        
        //Random randomNumber;

        public Customer(Weather weather, Random random4)
        {
            name = "remove";
            //randomNumber = new Random();
            SetChanceOfPurchase(weather, random4);

        }
        public void SetChanceOfPurchase (Weather weather, Random random4)
        {
            percentChanceToBuy = FindChanceOfPurchase(weather, random4);
        }
        
        public int FindChanceOfPurchase (Weather weather, Random random4)
        {
            Random randomNumber = new Random();
            int theTempPercent = 10;
            
            //Console.WriteLine("The temperature is: " + weather.GetTemperature());
            if (weather.temperature > 80)
            {
                theTempPercent = random4.Next(45, 66);
                
                //Console.WriteLine("25% failure rate");
            }
            else if (weather.temperature > 70)
            {
                theTempPercent = random4.Next(40, 66);
              
                //Console.WriteLine("40% failure rate");
            }
            else if (weather.temperature < 70)
            {
                theTempPercent = random4.Next(35, 66);
              
                //Console.WriteLine("50% failure rate");
            }
            
            return theTempPercent;
        }


        //public void ChanceOfPurchase(Weather weather, Random randomNumber)
        /*{
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
            //return percentChanceToBuy;
        }*/
    }
}
