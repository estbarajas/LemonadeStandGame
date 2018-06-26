using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Lemon: Item
    {
        public Lemon()
        {
            name = "Lemon";
        }
        private static List<string> AddLemon(int passedAmmount)
        {
            List<string> lemons = new List<string>();
            for (int i=0; i < passedAmmount; i++)
            {
                lemons.Add("Lemon " + i);
            }         
            return lemons;
        }
    }
}
