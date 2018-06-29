using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Day
    {
        public List<Customer> customers;
        public Weather weather;
        public int dayOfWeek;
        public Day()
        {
            customers = new List<Customer>();
            weather = new Weather();
            dayOfWeek = 0;
        }

        public void IncreaseDayOfWeek()
        {
            dayOfWeek++;
            Console.WriteLine("Current day: " + dayOfWeek);
        }

        public void CreatCustomers(Random randomNumber)
        {
            int min = 80;
            int max = 100;
            //weather.GetForecast();
            if (weather.weatherCondition == "sunny")
            {
                min += 20;
                max += 20;
            }
            else if(weather.weatherCondition == "rainy")
            {
                min -= 20;
                max -= 20;
            }
            else if (weather.weatherCondition == "hazy")
            {
                min -= 10;
                max -= 10;
            }
            int subsetOfTotalPossibleCustomers = randomNumber.Next(min, max);
            for (int i = 0; i < subsetOfTotalPossibleCustomers; i++)
            {
                Customer customer = new Customer(randomNumber);
                //customers.Add(new Customer(randomNumber));
            }
        }
    }
}
