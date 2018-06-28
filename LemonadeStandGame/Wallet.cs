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
            money = randomNumber.Next(35, 56);
        }
        public void AddMoneyAmmount(double profit)
        {
            money = money + profit;
        }
        public void RemoveMoneyAmmount(double loss)
        {
            money = money - loss;
        }
        public double MoneyToSpend()
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
        }
    }
}
