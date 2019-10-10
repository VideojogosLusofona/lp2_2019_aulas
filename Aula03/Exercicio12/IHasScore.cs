using System;

namespace Exercicio12
{
    /// <summary>
    /// This interface defines a type of object that has a score.
    /// </summary>
    public interface IHasScore : IEquatable<IHasScore>, IComparable<IHasScore>
    {
        /// <summary>
        /// Property representing a score.
        /// </summary>
        int Score { get; set; }
    }
}
