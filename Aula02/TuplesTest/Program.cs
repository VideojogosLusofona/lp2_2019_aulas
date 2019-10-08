using System;

namespace Aula02
{
    /// <summary>
    /// Programa para testar tuplos.
    /// </summary>
    class Program
    {
        /// <summary>
        /// O programa começa no método Main.
        /// </summary>
        /// <param name="args">Não utilizado.</param>
        static void Main(string[] args)
        {
            // Obter player e score de uma só vez
            Tuple<Player, float> playerAndScore = GetPlayerAndScore();

            // Imprimir características do player, sendo que o objeto do tipo
            // Player está no Item1 do tuplo
            Console.WriteLine($"Name   : {playerAndScore.Item1.Name}");
            Console.WriteLine($"Health : {playerAndScore.Item1.Health}");
            Console.WriteLine($"Armour : {playerAndScore.Item1.Armour}");
            
            // Imprimir score, que está no Item2 do tuplo
            Console.WriteLine($"Score  : {playerAndScore.Item2}");
        }

        /// <summary>
        /// Este método devolve um tuplo contendo o player e o seu score.
        /// </summary>
        /// <returns>Um tuplo contendo o player e o seu score.</returns>
        static Tuple<Player, float> GetPlayerAndScore()
        {
            // Criar novo player (usando sintaxe de inicialização de
            // propriedades)
            Player player = new Player()
            {
                Name = "Hanzo",
                Health = 100,
                Armour = 30
            };

            // Determinar o score do player, baseado na sua health e armour
            float score = player.Health * 10 + player.Armour * 5;

            // Devolver um tuplo contendo um player e o seu score
            return new Tuple<Player, float>(player, score);
        }
    }
}
