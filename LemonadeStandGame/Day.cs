﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Day
    {
        //public Customer customer;
        public List<Customer> customers;
        public Weather weather;
        public int dayOfWeek;
        Random randomNumber3;
        public int dailySales;
        public Day()
        {
            randomNumber3 = new Random();
            customers = new List<Customer>();
            weather = new Weather();
            dailySales = 0;
            //customer = new Customer(weather);
            dayOfWeek = 0;
        }

        public void IncreaseDayOfWeek()
        {
            dayOfWeek++;
            Console.WriteLine("Current day: " + dayOfWeek);
        }

        public void CreateCustomers()
        {
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
                Customer customer = new Customer(weather, randomNumber3);
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
                //Console.WriteLine("Got them, proof: " + customers.Count);
            }
            else if (customers.Count <= 0)
            {
                //Console.WriteLine("Empty, proof: " + customers.Count);
            }
        }

        public void DisplayCustomerListCount()
        {
            Console.WriteLine("\nThere is this many customers " + customers.Count() + ".");
        }

        public void DisplayPurchase()
        {
            //load the temphere
            //customer.ChanceOfPurchase(weather, randomNumber3);
            //customer.SetChanceOfPurchase(weather);

            for (int i=0; i <= customers.Count-1; i++)
            {
                if (customers.ElementAt(i).percentChanceToBuy >= 50)
                {
                    //Console.WriteLine("Customer: " + i + "has percent of " + customers.ElementAt(i).percentChanceToBuy);
                    //Console.WriteLine("bought");
                    dailySales++;
                }
                else if(customers.ElementAt(i).percentChanceToBuy < 50)
                {
                    //Console.WriteLine("Customer: " + i + "has percent of " + customers.ElementAt(i).percentChanceToBuy);
                    //Console.WriteLine("no buy");
                }
                //Console.WriteLine(customers.ElementAt(i).name);
            }
            Console.WriteLine("Total daily sales made: " + dailySales + " out of a possible " + customers.Count + ".");
            dailySales = 0;
            //Console.WriteLine("Sales affected by weather: " + (customers.Count - dailySales));
        }

    }
}
