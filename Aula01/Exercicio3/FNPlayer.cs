namespace Exercicio3
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
