﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Player
    {
        public string name;
        public Inventory inventory;
        public Recipe recipe;
        public Wallet wallet;
        public double totalIncome;
        public double dailyIncome;
        public Player()
        {
            inventory = new Inventory();
            recipe = new Recipe();
            wallet = new Wallet();
            name = "Default Stand";
        }
        public double SetTotalIncome()
        {
            totalIncome = wallet.money - 20.00;
            return totalIncome;
        }
        public double SetDailyIncome()
        {
            dailyIncome = wallet.money - 20.00 - totalIncome;
            return dailyIncome;
        }
    }
}
