using System;
using System.Collections.Generic;

namespace Exercicio03
{
    /// <summary>
    /// Test a collection of players.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Program starts here.
        /// </summary>
        /// <param name="args">Not used.</param>
        public static void Main(string[] args)
        {
            // The option selected by the user
            string option;
            // Initialize the player list with two players using collection
            // initialization syntax
            List<Player> players = new List<Player>() {
                new Player() { Name = "Best player ever", Score = 100 },
                new Player() { Name = "An even better player", Score = 500 }
            };

            // Main menu loop
            do
            {
                // Get option from user
                option = Menu();
                // Check option
                switch (option)
                {
                    case "i": // Insert player option
                        InsertPlayer(players);
                        break;
                    case "l": // List players option
                        ListPlayers(players);
                        break;
                    case "s": // Show players with score greater than
                        ShowPlayersWithScoreGreaterThan(players);
                        break;
                    case "q": // Quit
                        break;
                    default: // Unknown option
                        Console.WriteLine("Unknown option!");
                        break;
                }
                // Keep looping until user quits
            } while (option != "q");

        }

        /// <summary>
        /// Show main menu and get user option.
        /// </summary>
        /// <returns>User option.</returns>
        private static string Menu()
        {
            // Show menu
            Console.WriteLine("------------------");
            Console.WriteLine("(I)nsert player");
            Console.WriteLine("(L)ist all players");
            Console.WriteLine("(S)how players with score greater than x");
            Console.WriteLine("(Q)uit");
            Console.WriteLine("------------------");
            // Ask and return player option, removing whitespace before and
            // after the option and converting the option to lowercase
            return Console.ReadLine().Trim().ToLower();
        }

        /// <summary>
        /// Insert a player in the list.
        /// </summary>
        /// <param name="players">The list of players.</param>
        private static void InsertPlayer(List<Player> players)
        {
            // Required local variables
            string playerName, playerScoreStr;
            int playerScore;
            Player player;

            // Get player name
            Console.Write("Player name  : ");
            playerName = Console.ReadLine();

            // Get player score, must be valid integer
            while (true)
            {
                Console.Write("Player score : ");
                playerScoreStr = Console.ReadLine();

                // Check if score is valid integer
                if (int.TryParse(playerScoreStr, out playerScore))
                {
                    // If so, get out of loop
                    break;
                }
                // If not, show error message
                Console.WriteLine("Invalid integer, please try again");
            };

            // Instantiate new player (using property initialization syntax)
            player = new Player() { Name = playerName, Score = playerScore };

            // Add player to list
            players.Add(player);
        }

        /// <summary>
        /// List all players.
        /// </summary>
        /// <param name="players">The players list.</param>
        private static void ListPlayers(List<Player> players)
        {

            // Show player list
            Console.WriteLine("==== Player List ====");
            foreach (Player player in players)
            {
                // We're using the Player.ToString() method to show player info
                Console.WriteLine(player);
            }
            Console.WriteLine("=====================");
        }

        /// <summary>
        /// Show player with score greater than a user-specified value.
        /// </summary>
        /// <param name="players">List of players.</param>
        private static void
        ShowPlayersWithScoreGreaterThan(List<Player> players)
        {
            // Required local variables
            int minScore;

            Console.Write("Minimum player score : ");

            // Get minimum player score, must be valid integer
            // In this case we don't verify this, so if user inserts invalid
            // integer, program will crash
            minScore = Convert.ToInt32(Console.ReadLine());

            // Show players with at least this score
            Console.WriteLine("=== Players with score > {0} ===", minScore);
            foreach (Player player in
                GetPlayersWithScoreGreaterThan(players, minScore))
            {
                // We're using the Player.ToString() method to show player info
                Console.WriteLine(player);
            }
            Console.WriteLine("================================");

        }

        /// <summary>
        /// Get an enumerable containing players with score greater than the
        /// specified parameter <paramref name="minScore"/>.
        /// </summary>
        /// <param name="players">The list of all players.</param>
        /// <param name="minScore">
        /// The minimum score a player should have to be returned.
        /// </param>
        /// <returns>
        /// An enumerable containing players with score greater than the
        /// specified parameter <paramref name="minScore"/>.
        /// </returns>
        private static IEnumerable<Player>
        GetPlayersWithScoreGreaterThan(List<Player> players, int minScore)
        {
            // Create a new player list, only for players with score greater
            // than minScore
            List<Player> playersWithScoreGreaterThanX = new List<Player>();

            // Cycle through all players
            foreach (Player player in players)
            {
                // Does the current player have a score greater than minScore?
                if (player.Score > minScore)
                {
                    // If so, add it to new list
                    playersWithScoreGreaterThanX.Add(player);
                }
            }
            // Return list with players with score greater than minScore
            // We can do this because List<T> implements the IEnumerable<T>
            // interface
            return playersWithScoreGreaterThanX;
        }
    }
}
