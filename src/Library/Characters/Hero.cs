namespace RoleplayGame
{
    public class Hero : Character
    {
        public int VictoryPoints;

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }
    }
}