using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer: Hero
    {
        private int health = 100;

        private List<IItem> items = new List<IItem>();

        public Archer(string name)
        {
            this.Name = name;
            
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }

        public string Name { get; set; }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }
    }
}