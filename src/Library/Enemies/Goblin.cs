namespace RoleplayGame
{
    public class Goblin : Foe
    {
        public Goblin()
        {
            this.Name = "Goblin";
            this.Health = 200;
            this.AttackValue = 75;
            this.DefenseValue = 50;
            this.VP = 30;

            this.AddItem(new Sword());
            this.AddItem(new Shield());
        }
    }
}