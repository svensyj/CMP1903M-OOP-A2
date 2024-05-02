using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    public class SevensOut
    {
        public int Total;
        public int Play()
        {
            bool gameOver = false; // This is set to indicate whether the game is over or not


            int rollTotal; // Variable of two dice rolls
            while (!gameOver) // Loops until the game is over
            {
                // Creating two objects/instances of the Die class to show two die
                Die die1 = new Die(); 
                Die die2 = new Die();

                // This here shows if the two dice rolls are the same number, and if they are it will give double points
                // like in the rules. 
                if (die1.DieRolled == die2.DieRolled)
                {
                    rollTotal = (die1.DieRolled + die2.DieRolled) * 2;
                    Console.WriteLine("Double Points");
                }
                else
                {
                    rollTotal = die1.DieRolled + die2.DieRolled; // If different numbers are rolled then add
                }
                Console.WriteLine($"You rolled {rollTotal}"); // Print total value
                Total += rollTotal;
                // If statement checking if a 7 is rolled then it would print the score and end the game, for any of the players
                if (rollTotal == 7) 
                {
                    Console.WriteLine($"Your total is now {Total}"); 
                    gameOver = true; 
                }
                Console.ReadLine();

            }
            Console.WriteLine("End game");
            return Total;
        }
        // Multiplayer game
        public void Multiplayer()
        {
            int player1 = Play(); // Plays game for player 1 and stores the score
            Total = 0; // Resets total score, without this it would add the total for player 2 as well
            int player2 = Play();
            Console.WriteLine($"Player 1 score equals {player1}" +
                $"\nPlayer 2 score equals {player2}"); // Prints scores after the second game
        }
    }

}
