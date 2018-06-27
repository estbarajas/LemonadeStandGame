using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Wallet
    {
        public double money;
        public Wallet()
        {
            money = 20.00;
        }
        public void AddMoneyAmmount(double profit)
        {
            money = money + profit;
        }
        public void RemoveMoneyAmmount(double loss)
        {
            money = money - loss;
        }
    }
}
