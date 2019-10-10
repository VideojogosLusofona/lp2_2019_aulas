using System;

namespace Exercicio12
{
    /// <summary>
    /// This program tests our generic class, now making use of the
    /// <see cref="Player.ToString()"/> override.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Program starts here.
        /// </summary>
        /// <param name="args">Not used.</param>
        public static void Main(string[] args)
        {
            // Types of podium we'll test
            Podium<Player> podiumOfPlayers;
            Podium<int> podiumOfInts;

            // Test podium with 3 player objects, adding one at a time
            podiumOfPlayers = new Podium<Player>(3);
            podiumOfPlayers.Add(new Player() { Name = "Zé", Score = 1 });
            podiumOfPlayers.Add(new Player() { Name = "Ana", Score = 9 });
            podiumOfPlayers.Add(new Player() { Name = "Pedro", Score = 151 });
            podiumOfPlayers.Add(new Player() { Name = "Filipa", Score = 35 });
            podiumOfPlayers.Add(new Player() { Name = "Isaac", Score = 8 });

            // List players in the podium
            Console.WriteLine(" ==== Podium of Players ====");
            foreach (Player p in podiumOfPlayers)
            {
                Console.WriteLine($" -> {p}");
            }

            // Test podium of 5 ints, adding them all at once using collection
            // initialization syntax
            podiumOfInts = new Podium<int>(5)
            { 10, -1, -9, 500, -13, 55, 19, 101, -999, -2, -1, -7};

            // List ints in the podium
            Console.WriteLine(" ==== Podium of Ints ====");
            foreach (int i in podiumOfInts)
            {
                Console.WriteLine($" -> {i}");
            }

        }
    }
}
