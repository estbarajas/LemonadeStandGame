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
        public double spendableMoney;
        bool spendMoney;
        public Wallet()
        {
            //money = randomNumber.Next(35, 56);
            money = 20.00;
        }
        public void AddMoneyAmmount(double price)
        {
            money = money + price;
            //double addMoney = units * price;
            //money = money + addMoney;
            //money = money + addMoney;
        }
        public void RemoveMoneyAmmount(double units, double price)
        {
            double removeMoney = units * price;
            money = money - removeMoney;
            Console.WriteLine("Current money stack: " + money);
        }
       /* public double MoneyToSpend()
        {
            spendMoney = randomNumber.Next(0,2) == 0;
            if (spendMoney)
            {
                spendableMoney = money;
                Console.WriteLine("\nSpent all of it.");
            }
            else
            {
                spendableMoney = money - randomNumber.Next(0,6);
                Console.WriteLine("\nSpent limited.");
            }
            return spendableMoney;
        } */
    }
}
