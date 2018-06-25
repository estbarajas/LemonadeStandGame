using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandGame
{
    class Game
    {
        public UserInterface userInterface;
        public Game()
        {
            
        }
        public void ExecuteGame()
        {
            userInterface = new UserInterface();
            userInterface.DisplayWelcome();
            userInterface.DisplayRules();
        }



    }
}
