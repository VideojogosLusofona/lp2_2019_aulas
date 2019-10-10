using System;

namespace Exercicio05
{
    /// <summary>
    /// Class which represents a player, which has a name and a score.
    /// </summary>
    public class Player : IHasScore, IComparable<IHasScore>
    {
        /// <summary>
        /// Instance variable that contains the actual score and supports the
        /// Score property.
        /// </summary>
        private int score;

        /// <summary>
        /// The Score property, in accordance with the IHasScore interface.
        /// For this class, Score can never be less than zero.
        /// </summary>
        public int Score
        {
            get => score;

            set
            {
                // Make sure score is never less than zero
                if (value < 0)
                {
                    score = 0;
                }
                else
                {
                    score = value;
                }
            }
        }

        /// <summary>
        /// Auto-implemented property that represents the player's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// This method returns true if another instance of type IHasScore
        /// contains the same score as the current instance. This method is
        /// required because Player implements <c>IEquatable</c> (via
        /// <see cref="IHasScore"/>).
        /// </summary>
        /// <param name="other">
        /// An instance of a class that implements the IHasScore interface.
        /// </param>
        /// <returns>True if both instances have the same score.</returns>
        public bool Equals(IHasScore other)
        {
            if (other == null) return false;
            return Score == other.Score;
        }

        /// <summary>
        /// This method compares two players according to the
        /// <see cref="IComparable{T}"/> interface. Players with a higher
        /// score come before players with a lower score.
        /// </summary>
        /// <param name="other">
        /// An object implementing IHasScore which will be compared to the
        /// current player in terms of score.
        /// </param>
        /// <returns>
        /// A value that indicates the relative order of the objects being
        /// compared. If less than zero, the current player comes before
        /// <paramref name="other"/>; if zero, both players are in the same
        /// position; if greater than zero, the current player comes after
        /// <paramref name="other"/>.
        /// </returns>
        public int CompareTo(IHasScore other)
        {
            if (other == null) return -1;
            return other.Score - Score;
        }

        /// <summary>
        /// This method overrides <see cref="object.ToString()"/>.
        /// </summary>
        /// <returns>A string representing the player state.</returns>
        public override string ToString()
        {
            return $"My name is {Name} and my score is {Score}";
        }
    }
}
