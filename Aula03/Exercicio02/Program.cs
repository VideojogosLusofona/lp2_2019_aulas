using System;

namespace Exercicio02
{
    /// <summary>
    /// This class simply tests the remaining classes.
    /// </summary>
    public class Program
    {

        /// <summary>
        /// The program starts here and the tests are also done here.
        /// </summary>
        /// <param name="args">Not used.</param>
        public static void Main(string[] args)
        {
            // This local variable will contain the previous object when we
            // cycle thorugh the array (initially it's null)
            IHasScore previous = null;

            // Declare and create an array with space for 10 IHasScore objects
            IHasScore[] objectsThatHaveScore = new IHasScore[10];

            // Create 10 IHasScore objects (Player's and Hotel's) using the
            // syntax for initializing objects with properties
            objectsThatHaveScore[0] = new Player() {
                Name = "Ze", Score = 5 };

            objectsThatHaveScore[1] = new Hotel() {
                Name = "Four Seasonz", Score = 5,
                Description = "By the sea, near the river",
                NumberOfBedrooms = 50, NumberOfFloors = 8 };

            objectsThatHaveScore[2] = new Player() {
                Name = "Paula", Score = 100 };

            objectsThatHaveScore[3] = new Hotel() {
                Name = "Holiday Innz",
                Score = 2,
                Description = "In the middle of the action",
                NumberOfBedrooms = 80,
                NumberOfFloors = 12
            };

            objectsThatHaveScore[4] = new Player() {
                Name = "André", Score = 55 };

            objectsThatHaveScore[5] = new Hotel() {
                Name = "Ibiz",
                Score = 5,
                Description = "A low cost place",
                NumberOfBedrooms = 70,
                NumberOfFloors = 10
            };

            objectsThatHaveScore[6] = new Player() {
                Name = "Pedro", Score = 99 };

            objectsThatHaveScore[7] = new Hotel() {
                Name = "Sanaz Hotel",
                Score = 4,
                Description = "Almost perfect, but not quite",
                NumberOfBedrooms = 120,
                NumberOfFloors = 15
            };

            objectsThatHaveScore[8] = new Player() {
                Name = "Joana", Score = 25 };

            objectsThatHaveScore[9] = new Hotel() {
                Name = "Radizzon",
                Score = 3,
                Description = "For people who travel for work",
                NumberOfBedrooms = 40,
                NumberOfFloors = 6
            };

            // Go through the array
            foreach (IHasScore aThingWithAScore in objectsThatHaveScore)
            {
                // Show info, namely if current object is "equal" to the
                // previous one
                Console.WriteLine(
                    "Current object (a {0}) has a score of {1} and "
                    + "is {2} the previous",
                    aThingWithAScore.GetType().Name,
                    aThingWithAScore.Score,
                    aThingWithAScore.Equals(previous) ? 
                        "equal to" : "different from");

                // Make current object the previous one in the next iteration
                previous = aThingWithAScore;
            }

        }
    }
}
