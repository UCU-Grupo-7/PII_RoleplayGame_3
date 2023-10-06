using System;

namespace RoleplayGame
{
    public abstract class Hero : Character
    {
        public  Hero () : base()
        {
            this.VP = 0;
        }
        public void checkForVP(Character character)
        {
            if (character.Health == 0)
            {
                this.VP += character.VP;
                Console.WriteLine($"{this.Name} defeated {character.Name} and earned: 🌟 {character.VP} victory points!");
            }
        }

        public void Attack(Foe enemy)
        {
            Console.WriteLine($"{this.Name} attacks {enemy.Name} with 🗡️  {this.AttackValue}");
            if (enemy.Health > 0)
            { 

                enemy.Health -= this.AttackValue - enemy.DefenseValue; 

                Console.WriteLine($"{enemy.Name} now has ❤️ {enemy.Health} health");

                checkForVP(enemy);
            }
            else 
            {
                Console.WriteLine("The enemy is already dead 💀");
            } 
        }
        
    }
}