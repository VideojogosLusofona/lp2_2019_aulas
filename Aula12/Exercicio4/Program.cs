using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            World w1 = new World(2, new float[] { 2, 5.3f });
            World w2 = w1.ShallowCopy();
            World w3 = w1.NewCopy();

            w1.IncScore();

            Console.WriteLine(w1);
            Console.WriteLine(w2);
            Console.WriteLine(w3);
        }
    }
}
