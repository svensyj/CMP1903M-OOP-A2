using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Testing
    {
        public void Tests()
        {
            Die testDie1 = new Die();
            Die testDie2 = new Die();
            
 
            Debug.Assert(testDie1.DieRolled >= 1 && testDie1.DieRolled <= 6, "Die is not between 1 and 6"); // Assert that each die roll's result is within the range of 1 and 6
            
 
            Debug.Assert(testDie2.DieRolled >= 1 && testDie2.DieRolled <= 6, "Die is not between 1 and 6"); // Assert that each die roll's result is within the range of 1 and 6
            

            Console.WriteLine("Tests have been passed."); // Prints out to show that there are no errors

        }
    }
}