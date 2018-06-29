using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Weather
    {
        public List<string> forecast;
        public int temperature;
        public string weatherCondition;
        public Weather()
        {
            forecast = new List<string>() {"sunny", "rainy", "hazy"};
            weatherCondition = GetForecast();
            SetTemperature();
        }
        public void SetTemperature()
        {
            Random randomNumber = new Random();
            temperature = randomNumber.Next(60, 101);          
        }
        public int GetTemperature()
        {      
            return temperature;
        }
        public string GetForecast()
        {
            Random randomNumber = new Random();
            string randomForecast;
            randomForecast = forecast.ElementAt(randomNumber.Next(0, 3));
            return randomForecast;
        }
        public void GetWeeklyForecast()
        {
            Console.WriteLine("\nWeekly Forecast\n");
            Random randomNumber = new Random();
            string randomForecast;
            for (int i = 1; i <= 7; i++)
            {
                randomForecast = forecast.ElementAt(randomNumber.Next(0, 3));
                Console.WriteLine("\nDay " + i + ": " + randomForecast);
            }
        }
    }
}
