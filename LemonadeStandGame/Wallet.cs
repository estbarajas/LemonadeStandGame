using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Wallet
    {
        Random randomNumber = new Random();
        public double money;
        public Wallet()
        {
            money = 20.00;
        }
        public void AddMoneyAmmount(double price)
        {
            money = money + price;
        }
        public void RemoveMoneyAmmount(double units, double price)
        {
            double removeMoney = units * price;
            money = money - removeMoney;
            Console.WriteLine("Current money stack: " + money);
        }     
    }
}
