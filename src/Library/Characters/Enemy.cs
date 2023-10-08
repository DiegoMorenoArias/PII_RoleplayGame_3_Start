namespace RoleplayGame
{
    public class Enemy : Character
    {
        public int VictoryPointValue;
        public Enemy(int points)
        {
            this.VictoryPointValue = points;
            this.AddItem(new Sword());
        }

        public void ReceiveAttack(Hero hero)
        {
            if (this.DefenseValue < hero.AttackValue)
            {
                this.Health -= hero.AttackValue - this.DefenseValue;
            }
        }
    }
}