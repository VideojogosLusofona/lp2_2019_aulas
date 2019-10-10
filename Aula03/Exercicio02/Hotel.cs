namespace Exercicio02
{
    /// <summary>
    /// Class that represents an hotel.
    /// </summary>
    public class Hotel : IHasScore
    {
        /// <summary>
        /// Instance variable that contains the number of stars this hotel has.
        /// </summary>
        private int stars;

        /// <summary>
        /// The Score property, in accordance with the IHasScore interface.
        /// For this class, Score is supported by the stars instance variable,
        /// which represents the number of stars in this hotel.
        /// </summary>
        public int Score
        {
            get => stars;

            set
            {
                // Make sure the number of stars is between 0 and 5
                if (value < 0)
                {
                    stars = 0;
                }
                else if (value > 5)
                {
                    stars = 5;
                }
                else
                {
                    stars = value;
                }
            }
        }

        /// <summary>
        /// Auto-implemented property that represents the hotel name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Auto-implemented property that describes the hotel.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Auto-implemented property that contains the number of bedrooms in
        /// this hotel.
        /// </summary>
        public int NumberOfBedrooms { get; set; }

        /// <summary>
        /// Auto-implemented property that specifies the number of floors in
        /// this hotel.
        /// </summary>
        public int NumberOfFloors { get; set; }

        /// <summary>
        /// This method returns true if another instance of type IHasScore
        /// contains the same score as the current instance.
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
    }
}
