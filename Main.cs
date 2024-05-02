using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game(); // Creates new instance of Game class
            game.Start();
        }
    }
}
