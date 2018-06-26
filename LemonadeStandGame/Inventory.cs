using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Inventory
    {
        public List<Lemon> lemons;
        public List<Sugar> sugar;
        public List<Ice> ice;
        public List<Cup> cups;
        public Inventory()      
        {
            lemons = new List<Lemon>();
            sugar = new List<Sugar>();
            ice = new List<Ice>();
            cups = new List<Cup>();
        }
        public void DisplayLemonAmmount()
        {
            Console.WriteLine(lemons.Count);
        }
        public void DisplaySugarAmmount()
        {
            Console.WriteLine(sugar.Count);
        }
    }
}
