namespace RoleplayGame
{
    public class Goblin : Foe
    {
        public Goblin()
        {
            this.Name = "Goblin";
            this.Health = 200;
            this.VP = 30;

            this.AddItem(new GoblinAxe());
            this.AddItem(new GoblinShield());
        }
    }

    public class GoblinAxe : IAttackItem
    {
        public int AttackValue 
        {
            get
            {
                return 55;
            } 
        }
    }

    public class GoblinShield : IDefenseItem
    {
        public int DefenseValue 
        {
            get
            {
                return 55;
            } 
        }
    }
}