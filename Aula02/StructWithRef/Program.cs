using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Wrapper w = new Wrapper();
            w.nums = new int[3] { 10, 20, 30 };
            w.someValue = 40;
            UpdateArray(w);
            PrintStruct(w);
            NewArray(w);
            PrintStruct(w);
        }

        static void UpdateArray(Wrapper w)
        {
            w.nums[1] = 200;
            w.someValue = 400;
        }

        static void NewArray(Wrapper w)
        {
            w.nums = new int[3] { 1, 2, 3 };
            w.someValue = 4;
        }

        static void PrintStruct(Wrapper w)
        {
            foreach (int i in w.nums)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(w.someValue);
        }
    }
}
