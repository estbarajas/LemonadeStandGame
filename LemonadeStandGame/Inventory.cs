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
            Console.WriteLine("\n[Ammount of lemons owned: " + lemons.Count + "]");
        }
        public void DisplaySugarAmmount()
        {
            Console.WriteLine("\n[Ammount of sugar owned: " + sugar.Count + "]");
        }
        public void DisplayIceAmmount()
        {
            Console.WriteLine("\n[Ammount of ice owned: " + ice.Count + "]");
        }
        public void DisplayCupAmmount()
        {
            Console.WriteLine("\n[Ammount of cups owned: " + cups.Count + "]");
        }
        public void RemoveIngredients(int ammountToRemove)
        {
            for (int i = 0; i < ammountToRemove; i++)
            {
                lemons.RemoveAt(0);
                sugar.RemoveAt(0);
                ice.RemoveAt(0);
                cups.RemoveAt(0);
                //Console.WriteLine("Removed 1 of all.");
            }
        }
        public void OutOfMaterials()
        {
            Console.WriteLine("Out of materials. Missed sale opportunity.");
        }
        public void ChooseRecipe()
        {
            RemoveIngredients(1);
        }
    }
}
