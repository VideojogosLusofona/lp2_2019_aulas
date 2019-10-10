using System;

namespace Exercicio5
{
    /// <summary>
    /// This program tests four different approaches of returning multiple
    /// items from a method. These items consist of a random integer, a random
    /// double and a random boolean.
    /// </summary>
    public class Program
    {
        // ////////////////// //
        // Instance variables //
        // ////////////////// //

        /// <summary>
        /// The random number generator instance is placed here as an instance
        /// variable.
        /// </summary>
        private Random rand;

        // /////////////// //
        // Private methods //
        // /////////////// //

        /// <summary>
        /// This is a private method which returns a random integer.
        /// </summary>
        /// <returns>A random integer.</returns>
        private int GetRandomInt()
        {
            return rand.Next();
        }

        /// <summary>
        /// This is a private method which returns a random double.
        /// </summary>
        /// <returns>A random double.</returns>
        private double GetRandomDouble()
        {
            return rand.NextDouble();
        }

        /// <summary>
        /// This is a private method which returns a random boolean.
        /// </summary>
        /// <returns>A random boolean.</returns>
        private bool GetRandomBool()
        {
            // First, get a random integer between 0 and 1
            int zeroOrOne = rand.Next(2);
            // Then convert the integer to a boolean and return it
            return Convert.ToBoolean(zeroOrOne);
        }

        // //////////// //
        // Constructors //
        // //////////// //

        public Program()
        {
            // Initialize the random number generator
            rand = new Random();
        }

        // ////////////// //
        // Static methods //
        // ////////////// //

        /// <summary>
        /// The program starts here.
        /// </summary>
        /// <param name="args">Command line arguments are not used.</param>
        public static void Main(string[] args)
        {
            // Declare necessary local variables
            object[] stuffInArray;
            Stuff stuffInInstance;
            int stuffInt;
            double stuffDouble;
            bool stuffBool;
            Tuple<int, double, bool> stuffInTuple;

            // Create a new instance of program
            Program prog = new Program();

            // Test the four public methods
            stuffInArray = prog.GetStuffInArray();
            stuffInInstance = prog.GetStuffInInstance();
            prog.GetStuffInOutParams(out stuffInt, out stuffDouble, out stuffBool);
            stuffInTuple = prog.GetStuffInTuple();

            // Print the stuff in the array
            PrintStuff("Array",
                (int)stuffInArray[0],
                (double)stuffInArray[1],
                (bool)stuffInArray[2]);

            // Print the stuff in the Stuff instance
            PrintStuff("Instance",
                stuffInInstance.MyInt,
                stuffInInstance.MyDouble,
                stuffInInstance.MyBool);

            // Print the stuff in the out parameters
            PrintStuff("Out params", stuffInt, stuffDouble, stuffBool);

            // Print the stuff in the tuple
            PrintStuff("Tuple",
                stuffInTuple.Item1,
                stuffInTuple.Item2,
                stuffInTuple.Item3);
        }

        /// <summary>
        /// This method simply prints the random items.
        /// </summary>
        /// <param name="info">Information about the items.</param>
        /// <param name="i">The integer.</param>
        /// <param name="d">The double</param>
        /// <param name="b">The boolean.</param>
        private static void PrintStuff(string info, int i, double d, bool b)
        {
            Console.WriteLine($"=== Stuff in {info} === ");
            Console.WriteLine($"  Integer = {i}");
            Console.WriteLine($"  Double  = {d}");
            Console.WriteLine($"  Boolean = {b}");
            Console.WriteLine();
        }

        // ////////////// //
        // Public methods //
        // ////////////// //

        /// <summary>
        /// Get the random items in an array of objects.
        /// </summary>
        /// <returns>An array of objects containing the random items.</returns>
        public object[] GetStuffInArray()
        {
            // Create an array of 3 objects
            object[] anArray = new object[3];

            // Place the random int, double and bool in the array
            anArray[0] = GetRandomInt();
            anArray[1] = GetRandomDouble();
            anArray[2] = GetRandomBool();

            // Return the array
            return anArray;
        }

        /// <summary>
        /// Get the random items in an instance of Stuff, a class specifically
        /// built for this purpose.
        /// </summary>
        /// <returns>
        /// An instance of the Stuff class containing the random items.
        /// </returns>
        public Stuff GetStuffInInstance()
        {
            // Create and return a new instance of stuff containing the random
            // items
            return new Stuff(GetRandomInt(), GetRandomDouble(), GetRandomBool());
        }

        /// <summary>
        /// Get the random items in out parameters.
        /// </summary>
        /// <param name="i">Out variable where to put the integer.</param>
        /// <param name="d">Out variable where to put the double.</param>
        /// <param name="b">Out variable where to put the boolean.</param>
        public void GetStuffInOutParams(out int i, out double d, out bool b)
        {
            // Place the random items in out var
            i = GetRandomInt();
            d = GetRandomDouble();
            b = GetRandomBool();
        }

        /// <summary>
        /// Get the random items in a tuple.
        /// </summary>
        /// <returns>A tuple containing the random items.</returns>
        public Tuple<int, double, bool> GetStuffInTuple()
        {
            return new Tuple<int, double, bool>(
                GetRandomInt(), GetRandomDouble(), GetRandomBool());
        }

    }
}
