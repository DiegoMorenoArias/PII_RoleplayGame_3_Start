using System.Collections.Generic;

namespace RoleplayGame
{
    public class Encounter
    {
        public static void DoEncounter(List<Hero> heroes, List<Enemy> enemies)
        {
            while (heroes.Count>0 && enemies.Count>0)
            { 
                foreach (Enemy enemy in enemies)
                {
                    heroes[enemies.IndexOf(enemy)%heroes.Count].ReceiveAttack(enemy.AttackValue);
                    if (heroes[enemies.IndexOf(enemy)%heroes.Count].Health <= 0)
                    {
                        heroes.Remove(heroes[enemies.IndexOf(enemy)%heroes.Count]);
                    }
                }
                foreach (Hero hero in heroes)
                {
                    enemies[heroes.IndexOf(hero)%enemies.Count].ReceiveAttack(hero);
                    if (enemies[heroes.IndexOf(hero)%enemies.Count].Health <= 0)
                    {
                        hero.VictoryPoints += enemies[heroes.IndexOf(hero)%enemies.Count].VictoryPointValue;
                        enemies.Remove(enemies[heroes.IndexOf(hero)%enemies.Count]);
                    }
                }
            }
            foreach (Hero hero in heroes)
            {
                if (hero.VictoryPoints >= 5)
                {
                    hero.Cure();
                }
                hero.VictoryPoints = 0;
            }
        }
    }
}