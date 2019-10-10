namespace Exercicio5
{
    /// <summary>
    /// This class supports the GetStuffInInstance method in the Program
    /// class. It is an immutable class that simply keeps the three items.
    /// </summary>
    public class Stuff
    {
        /// <summary>
        /// Auto-implemented read-only property containing the integer value. 
        /// </summary>
        public int MyInt { get; }

        /// <summary>
        /// Auto-implemented read-only property containing the double value. 
        /// </summary>
        public double MyDouble { get; }

        /// <summary>
        /// Auto-implemented read-only property containing the boolean value. 
        /// </summary>
        public bool MyBool { get; }

        /// <summary>
        /// This constructor creates a new instance of the Stuff class with
        /// the specified values.
        /// </summary>
        /// <param name="myInt">The integer value to keep.</param>
        /// <param name="myDouble">The double value to keep.</param>
        /// <param name="myBool">The boolean value to keep.</param>
        public Stuff(int myInt, double myDouble, bool myBool)
        {
            // Store the given items in the instance properties.
            MyInt = myInt;
            MyDouble = myDouble;
            MyBool = myBool;
        }
    }
}