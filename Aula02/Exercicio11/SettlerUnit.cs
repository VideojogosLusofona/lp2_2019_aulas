using System;

namespace Exercicio11
{
    public class SettlerUnit : Unit
    {
        public override float Value => 5;

        public SettlerUnit(int mov, int health) : base(mov, health)
        {
            // Construction is delegated to base class constructor
        }

        public void Settle(Vector2 v)
        {
            Console.WriteLine($"Created a new settlement at ({v.X},{v.Y})");
        }
    }
}