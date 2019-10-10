using System;
using System.Collections.Generic;

namespace Exercicio06
{
    /// <summary>
    /// Project StringCollections from aula 3.
    /// </summary>
    public class Program
    {

        /// <summary>
        /// Program starts here.
        /// </summary>
        /// <param name="args">Not used.</param>
        public static void Main(string[] args)
        {
            // Our strings, alphabetically ordered; s4 and s5 are the same
            // phrase.
            string s1 = "A joke is a very serious thing.";
            string s2 = "Fortune favors the brave.";
            string s3 = "In teaching others we teach ourselves.";
            string s4 = "The true sign of intelligence is not knowledge " 
                + "but imagination.";
            string s5 = "The true sign of intelligence is not knowledge "
                + "but imagination.";

            // Our string collections
            // Only List and HashSet can be filled using collection
            // initialization syntax (do you know why?)
            List<string> sList = new List<string>() { s1, s2, s3, s4, s5 };
            Stack<string> sStack = new Stack<string>();
            Queue<string> sQueue = new Queue<string>();
            HashSet<string> sSet = new HashSet<string>() { s1, s2, s3, s4, s5 };

            // Fill the stack
            sStack.Push(s1);
            sStack.Push(s2);
            sStack.Push(s3);
            sStack.Push(s4);
            sStack.Push(s5);

            // Fill the queue
            sQueue.Enqueue(s1);
            sQueue.Enqueue(s2);
            sQueue.Enqueue(s3);
            sQueue.Enqueue(s4);
            sQueue.Enqueue(s5);

            // Print the strings in the list
            Console.WriteLine(
                "==== Strings in list (total of {0}) ====", sList.Count);
            foreach (string s in sList)
            {
                Console.WriteLine($"\t{s}");
            }
            Console.WriteLine();

            // Print the strings in the stack
            Console.WriteLine(
                "==== Strings in stack (total of {0}) ====", sStack.Count);
            foreach (string s in sStack)
            {
                Console.WriteLine($"\t{s}");
            }
            Console.WriteLine();

            // Print the strings in the queue
            Console.WriteLine(
                "==== Strings in queue (total of {0}) ====", sQueue.Count);
            foreach (string s in sQueue)
            {
                Console.WriteLine($"\t{s}");
            }
            Console.WriteLine();

            // Print the strings in the set
            Console.WriteLine(
                "==== Strings in set (total of {0}) ====", sSet.Count);
            foreach (string s in sSet)
            {
                Console.WriteLine($"\t{s}");
            }
            Console.WriteLine();

            //  Wait for user to press a key
            Console.ReadKey();
        }
    }
}
