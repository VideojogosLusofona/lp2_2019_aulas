using System;
using System.Collections.Generic;

namespace Exercicio10
{
    /// <summary>
    /// MyGenericMethod project.
    /// </summary>
    public class Program
    {

        /// <summary>
        /// The program starts here and the tests are also done here.
        /// </summary>
        /// <param name="args">Not used.</param>
        public static void Main(string[] args)
        {

            // Stack to put some stuff on
            Stack<IHasScore> stuff = new Stack<IHasScore>();

            // Let's put four players in the stack
            stuff.Push(new Player() { Name = "Ze", Score = 5 });
            stuff.Push(new Player() { Name = "John", Score = 15 });
            stuff.Push(new Player() { Name = "Silva", Score = 25 });
            stuff.Push(new Player() { Name = "Andreia", Score = 45 });

            // Let's put two hotels in the stack
            stuff.Push(new Hotel() {
                Name = "Four Seasonz", Score = 5,
                Description = "By the sea, near the river",
                NumberOfBedrooms = 50, NumberOfFloors = 8 });

            stuff.Push(new Hotel() {
                Name = "Holiday Innz",
                Score = 2,
                Description = "In the middle of the action",
                NumberOfBedrooms = 80,
                NumberOfFloors = 12});

            // Let's count the number of players in the stack
            Console.WriteLine("Number of players in stack is {0}",
                 CountItems<Player>(stuff));

            // Let's count the number of hotels in the stack
            Console.WriteLine("Number of hotels in stack is {0}",
                 CountItems<Hotel>(stuff));
        }

        /// <summary>
        /// Count items of the given generic type.
        /// </summary>
        /// <typeparam name="T">
        /// The generic type to count items of. Restricted to
        /// <see cref="IHasScore"/>.
        /// </typeparam>
        /// <param name="allItems">Iterable containing items to count.</param>
        /// <returns>Number of items of the given generic type.</returns>
        public static int CountItems<T>(IEnumerable<IHasScore> allItems)
            where T : IHasScore
        {
            // Initial count is zero
            int count = 0;

            // Cycle through the iterable
            foreach(IHasScore item in allItems)
            {
                // If item is of the specified generic type, increment count
                if (item is T) count++;
            }

            // Return item count
            return count;
        }
    }
}
