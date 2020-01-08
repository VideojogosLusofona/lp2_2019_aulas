using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            SetValue();
            PrintValue();
        }

        private static void SetValue()
        {
            SingletonFloat.Instance.Value = 22;
        }

        private static void PrintValue()
        {
            Console.WriteLine(SingletonFloat.Instance.Value);
        }
    }
}
