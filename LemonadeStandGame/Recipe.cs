using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Recipe
    {
        public Recipe()
        {
                
        }
        public void UseLemonAmmount(Inventory inventory) // make this into a switchstatement xd
        {
            Console.WriteLine("Enter lemons per pitcher.");
            string userInput = Console.ReadLine();
        }
        public void UseSugarAmmount(Inventory inventory)
        {
            Console.WriteLine("Enter sugar cups per pitcher.");
            string userInput = Console.ReadLine();
        }
        public void UseIceAmmount(Inventory inventory)
        {
            Console.WriteLine("Enter ice per pitcher.");
            string userInput = Console.ReadLine();
        }
        public void UseCupAmmount(Inventory inventory)
        {
            inventory.cups.RemoveAt(inventory.cups.Count - 1);
        }
    }
}
