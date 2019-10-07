namespace Exercicio4
{
    /// <summary>
    /// Class that represents a Fortnite player.
    /// </summary>
    class FNPlayer
    {

        /// <summary>
        /// The player's weapon.
        /// This is an instance variable and as such, it should not be public.
        /// </summary>
        public string weapon;

        /// <summary>
        /// Is the player alive?
        /// This is an instance variable and as such, it should not be public.
        /// </summary>
        public bool alive;

        /// <summary>
        /// The player's health.
        /// This is an instance variable and as such, it should not be public.
        /// </summary>
        public float health;

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

            // Set initial weapon
            this.weapon = weapon;

            // The 'this' keyword differentiates between the instance
            // variables and the local variables/parameters
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
