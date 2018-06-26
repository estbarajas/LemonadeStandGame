using System;
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
        public Player()
        {
            inventory = new Inventory();
            name = "John";
        }
    }
}
