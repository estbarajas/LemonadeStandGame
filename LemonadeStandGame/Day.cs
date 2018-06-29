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
        Random randomNumber3;
        public Day()
        {
            randomNumber3 = new Random();
            customers = new List<Customer>();
            weather = new Weather();
            dayOfWeek = 0;
        }

        public void IncreaseDayOfWeek()
        {
            dayOfWeek++;
            Console.WriteLine("Current day: " + dayOfWeek);
        }

        public void CreateCustomers()
        {
            Console.WriteLine(weather.weatherCondition);
            int min = 25;
            int max = 35;
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
            int subsetOfTotalPossibleCustomers = randomNumber3.Next(min, max);
            for (int i = 0; i < subsetOfTotalPossibleCustomers; i++)
            {
                //Customer customer = new Customer();
                //Console.WriteLine(i);
                Customer customer = new Customer();
                customers.Add(customer);
                //customers.Add(new Customer(randomNumber));
            }
        }

        public void DeleteCustomers()
        {
            
            if(customers.Count() > 0)
            {
                for (int i = 0; i < customers.Count; i++)
                {
                    customers.Clear();
                }
                Console.WriteLine("Got them, proof: " + customers.Count);
            }
            else if (customers.Count <= 0)
            {
                Console.WriteLine("Empty, proof: " + customers.Count);
            }
        }

        public void DisplayCustomerListCount()
        {
            Console.WriteLine("There is this many customers " + customers.Count());
        }
    }
}
