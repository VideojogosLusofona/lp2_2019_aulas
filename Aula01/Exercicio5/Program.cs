// The System library is required to use the Console class
using System;

// Namespaces are a way to organize our classes
namespace Exercicio5
{
    /// <summary>
    /// The Program class is the default class when we create a new Visual
    /// Studio console project.
    /// </summary>
    class Program
    {

        /// <summary>
        /// The Main method is where the program starts.
        /// </summary>
        /// <param name="args">
        /// Program console arguments, not used in this example.
        /// </param>
        static void Main(string[] args)
        {

            // Create a player instance using the empty constructor
            FNPlayer player1 = new FNPlayer();

            // Create another player instance using the constructor with
            // parameters
            FNPlayer player2 = new FNPlayer(75, "Assault Weapon (M4)");

            // Let's make player1 attack player2, and check player2's health
            // before and after the attack
            Console.WriteLine("Player 2 health before attack: "
                + player2.GetHealth());
            // Notice we now use the instance's GetHealth() method to obtain
            // the player's health instead of directly accessing the player's
            // health instance variable

            player1.Attack(player2);

            Console.WriteLine("Player 2 health after attack: "
                + player2.GetHealth());

            // Change player1 health using the respective setter method,
            // checking player1's health before and after the change
            Console.WriteLine("Player 1 health before change: "
                + player1.GetHealth());

            player1.SetHealth(24);

            Console.WriteLine("Player 1 health after change: "
                + player1.GetHealth());

        }
    }
}
