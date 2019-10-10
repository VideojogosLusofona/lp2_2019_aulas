using System;

namespace Exercicio11
{
    class Program
    {
        private static Random rnd;

        static void Main(string[] args)
        {
            // Initialize random number generator
            rnd = new Random();

            // Create two different units
            SettlerUnit settler = new SettlerUnit(2, 20);
            MilitaryUnit military = new MilitaryUnit(4, 100, 20);

            // Put them in an array
            Unit[] units = new Unit[] { settler, military };

            // Military unit attacks settler
            military.Attack(settler);

            // Make settler settle somewhere
            settler.Settle(GetRandomVector());

            // Empty line
            Console.WriteLine();

            // See and do common stuff in both units
            foreach (Unit u in units)
            {
                // What unit is this?
                Console.WriteLine(u);

                // Move current unit somewhere
                u.Move(GetRandomVector());

                // Leave empty line between both units
                Console.WriteLine();
            }
        }

        private static Vector2 GetRandomVector()
        {
            return new Vector2(rnd.Next(100), rnd.Next(100));
        }
    }
}
