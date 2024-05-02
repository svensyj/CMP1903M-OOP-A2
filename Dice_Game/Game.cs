using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    public class Game
    {
        public void ShowMenu()
        {
            Console.WriteLine("1. Play Sevens Out");
            Console.WriteLine("2. Perform Tests");
            Console.WriteLine("3. Exit");
        }
        // Above is just showing a small little menu interface, that allows the player select what they want from there

        public void Start()
        {
            bool exit = false;
            do
            {
                ShowMenu();
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        SevensOut sevensOutGame = new SevensOut();
                        sevensOutGame.Multiplayer();
                        break;
                    case "2":
                        Testing Testing = new Testing();
                        Testing.Tests();
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (!exit);
        }
        // Above is what allows the function of swapping between classes and features inside of the application. For instance this allows people to choose a different value
        // than the menu, but it will tell them that there was an error and that it was an invalid input and allows them to carry on.
    }
}
