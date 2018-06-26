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
            for (int i = 0; i < 100; i++)
            {
                Sugar sugar = new Sugar();
                inventory.sugar.Add(sugar);
            }
        }
        public void BuyIce(Inventory inventory)
        {
            for (int i = 0; i < 100; i++)
            {
                Ice ice = new Ice();
                inventory.ice.Add(ice);
            }
        }
        public void BuyCups(Inventory inventory)
        {
            for (int i = 0; i < 100; i++)
            {
                Cup cups = new Cup();
                inventory.cups.Add(cups);
            }
        }
    }
}
