// The System library is required to use the Console class
using System;

// Namespaces are a way to organize our classes
namespace Exercicio7
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
                + player2.Health);
            // Notice we now use the instance's `Health` property to obtain
            // the player's health instead of the `GetHealth()` method

            player1.Attack(player2);

            Console.WriteLine("Player 2 health after attack: "
                + player2.Health);

            // Change player1 health using the respective property,
            // checking player1's health before and after the change
            Console.WriteLine("Player 1 health before change: "
                + player1.Health);

            player1.Health = 24;

            Console.WriteLine("Player 1 health after change: "
                + player1.Health);

            // Try to change player1 health to 200 and check what its actual
            // value is
            player1.Health = 200;
            Console.WriteLine("Player 1 health after trying to set it to 200: "
                + player1.Health);

            // Now let's allow for greater maximum health for all player
            // instances
            Console.WriteLine("Setting maximum allowed health to 250...");
            FNPlayer.MaxHealth = 250;

            // And let's try to set player2 health to 200, and then checking
            // what the actual value is
            player2.Health = 200;
            Console.WriteLine("Player 2 health after trying to set it to 200: "
                + player2.Health);
        }
    }
}
