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
            userInterface = new UserInterface();
        }
        public void ExecuteGame()
        {
            
            userInterface.DisplayWelcome();
            userInterface.DisplayRules();
            userInterface.MainMenu();
        }



    }
}
