namespace Exercicio5
{
    /// <summary>
    /// Class that represents a Fortnite player.
    /// </summary>
    class FNPlayer
    {

        /// <summary>
        /// The player's weapon.
        /// In this exercise we made this variable private, as it should be.
        /// </summary>
        private string weapon;

        /// <summary>
        /// Is the player alive?
        /// In this exercise we made this variable private, as it should be.
        /// </summary>
        private bool alive;

        /// <summary>
        /// The player's health.
        /// In this exercise we made this variable private, as it should be.
        /// </summary>
        private float health;

        /// <summary>
        /// Empty constructor, will initialize all instance variables to
        /// adequate defaults.
        /// </summary>
        public FNPlayer()
        {
            health = 100;
            weapon = "Pickaxe";
            alive = true;
        }

        /// <summary>
        /// This constructor initializes player health and weapon with values
        /// specified by the code who creates a new player instance.
        /// </summary>
        /// <param name="health">Initial player health.</param>
        /// <param name="weapon">Initial player weapon.</param>
        public FNPlayer(float health, string weapon)
        {
            // We now use the setter method to set the player's health instead
            // of doing it directly
            SetHealth(health);

            // Set initial weapon
            this.weapon = weapon;

            // The 'this' keyword differentiates between the instance
            // variables and the local variables/parameters
        }

        /// <summary>
        /// Getter method which returns the player's health.
        /// </summary>
        /// <returns>The player's health.</returns>
        public float GetHealth()
        {
            return health;
        }

        /// <summary>
        /// Setter method which sets the player's health.
        /// </summary>
        /// <param name="health">The health to set in the player.</param>
        public void SetHealth(float health)
        {
            if (health <= 0)
            {
                // If health is zero or less, player is set as dead
                Die();
            }
            else
            {
                // Set initial health (if it is not zero or less)
                this.health = health;
            }
            // 'this.health' refers to the instance variable
            // 'health' refers to the local variable/method parameter
        }

        /// <summary>
        /// Attack an enemy.
        /// </summary>
        /// <param name="enemy">Enemy to attack.</param>
        public void Attack(FNPlayer enemy)
        {
            // We just started to develop our game, so for now let's just
            // cause a damage of 10 on an enemy
            enemy.TakeDamage(10);
        }

        /// <summary>
        /// Take damage from an enemy or possibly something else.
        /// </summary>
        /// <param name="damage">Damage to take.</param>
        public void TakeDamage(float damage)
        {
            // Is the damage greater than the player's current health?
            if (health < damage)
            {
                Die();
            }
            else
            {
                // Lose health in the amount specified by the damage variable
                health -= damage;
            }
        }

        /// <summary>
        /// Kill this player.
        /// </summary>
        public void Die()
        {
            health = 0;
            alive = false;
        }
    }
}
