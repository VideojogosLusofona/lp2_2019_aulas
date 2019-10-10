namespace Exercicio11
{
    public class MilitaryUnit : Unit
    {
        public int AttackPower { get; }
        public int XP { get; set; }

        public override int Health => base.Health + XP;

        public override float Value => AttackPower + XP;

        public MilitaryUnit(int mov, int health, int attackPower)
            : base(mov, health)
        {
            AttackPower = attackPower;
            XP = 0;
        }
        public void Attack(Unit u)
        {
            // Attack other unit, take half their health
            u.Health /= 2;
            // Gain XP
            XP++;
        }

        public override string ToString()
        {
            return base.ToString() + $", AtttackPower={AttackPower}, XP={XP}";
        }
    }
}