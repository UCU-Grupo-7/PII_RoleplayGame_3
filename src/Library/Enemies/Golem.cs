namespace RoleplayGame
{
    public class Golem : Foe
    {
        public Golem(){

            this.Name = "Golem";
            this.Health = 400;
            this.AttackValue = 20;
            this.DefenseValue = 20;
            this.VP = 30;


            this.AddItem(new Armor());
            this.AddItem(new Axe());


        }

    }
    
}