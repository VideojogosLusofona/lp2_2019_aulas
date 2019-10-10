using System;

namespace Exercicio02
{
    /// <summary>
    /// This interface defines a type of object that has a score.
    /// </summary>
    public interface IHasScore : IEquatable<IHasScore>
    {
        /// <summary>
        /// Property representing a score.
        /// </summary>
        int Score { get; set; }
    }
}
