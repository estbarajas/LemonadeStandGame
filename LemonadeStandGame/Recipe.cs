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
        public void UseIngredients(Inventory inventory)
        {
          
        }
        public void UseLemonAmmount(Inventory inventory) // make this into a switchstatement xd
        {
            Console.WriteLine("Enter lemons per pitcher.");
            string userInput = Console.ReadLine();
            inventory.lemons.RemoveAt(inventory.lemons.Count - 1);
        }
        public void UseSugarAmmount(Inventory inventory)
        {
            Console.WriteLine("Enter sugar cups per pitcher.");
            string userInput = Console.ReadLine();
            inventory.sugar.RemoveAt(inventory.sugar.Count - 1);
        }
        public void UseIceAmmount(Inventory inventory)
        {
            Console.WriteLine("Enter ice per pitcher.");
            string userInput = Console.ReadLine();
            inventory.ice.RemoveAt(inventory.ice.Count - 1);
        }
        public void UseCupAmmount(Inventory inventory)
        {
            inventory.cups.RemoveAt(inventory.cups.Count - 1);
        }
    }
}
