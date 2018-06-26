using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Inventory
    {
        public Item lemon;
        public Item sugar;
        public Item ice;
        public Item cup;
        public Inventory()
        {
            lemon = new Lemon();
            sugar = new Sugar();
            ice = new Ice();
            cup = new Cup();
        }
        //display amount of each
    }
}
