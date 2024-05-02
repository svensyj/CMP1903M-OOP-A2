using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    public class Die
    {
        private static Random random = new Random(); // Private variable used to generate random numbers
        public int DieRolled { get; private set; } // This is where the result of a die roll will get placed into


        public Die()
        {
            Roll(); 
        }

        public int Roll()
        {
            DieRolled = random.Next(1, 7); // Generates random number between 1 and 6, and then the DieRolled will be stored in the property waiting to be used.
            return DieRolled;
        }
    }
}
