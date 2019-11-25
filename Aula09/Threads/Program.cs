using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(CountTo250);
            thread1.Start();
            Thread thread2 = new Thread(CountTo250);
            thread2.Start();
            thread1.Join();
            thread2.Join();
            Console.ReadKey();
        }

        public static void CountTo250()
        {
            for (int index = 0; index < 250; index++)
                Console.WriteLine(index + 1);
        }
    }
}
