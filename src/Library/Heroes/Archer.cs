using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer : Heroe
    {
        //private int baseHealth = 150;
        private int health = 150;
        public Archer(string name)
        {
            this.Name = name; 
            
            //this.Health = baseHealth;

            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }
    }
}