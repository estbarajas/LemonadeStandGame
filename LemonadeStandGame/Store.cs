using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Store
    {
        public Store()
        {

        }
        public void BuyLemons(Inventory inventory) //CHANGE THE HARD CODED 100
        {          
            for (int i = 0; i < 100; i++)
            {
                Lemon lemon = new Lemon();
                inventory.lemons.Add(lemon);
            }
        }
        public void BuySugar(Inventory inventory)
        {

        }
        public void BuyIce()
        {

        }
        public void BuyCups()
        {

        }
    }
}
