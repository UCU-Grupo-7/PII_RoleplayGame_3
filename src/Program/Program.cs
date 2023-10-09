using System;
using System.Text;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
           /*  SpellsBook book = new SpellsBook();
            book.AddSpell(new Fireball());
            book.AddSpell(new Thunder());

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.AddItem(book); 

            Dwarf gimli = new Dwarf("Gimli");

            Archer legolas = new Archer("Legolas");

            Console.WriteLine($"Gimli has ❤️ {gimli.Health} Gimli has defense: {gimli.DefenseValue}. Gimli PV points: {gimli.VP}");

            gandalf.Attack(gimli);
            gandalf.Attack(gandalf); */

/*             Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Legolas has ❤️ {legolas.Health}");
            Console.WriteLine($"gandalf has ❤️ {gandalf.Health}"); */

            /* Console.WriteLine($"Legolas has ❤️ {legolas.Health}");
            
            gimli.Cure();
            legolas.Cure();

            Foe goblin = new Goblin();

            /* gandalf.Attack(goblin);

            gandalf.Attack(goblin);

            gandalf.Attack(goblin);

            Console.WriteLine($"Gandalf has ❤️ {gandalf.VP} victory points");

            Console.WriteLine(gandalf is Hero); */

            Foe goblin = new Goblin();
            Foe golem = new Golem();
            Hero dwarf = new Dwarf("dwarf name");
            Hero dwarf2 = new Dwarf("dwarf 2 name");

            HeroVSFoe HvF = new HeroVSFoe();
            HvF.AddCharacter(goblin);
            HvF.AddCharacter(golem);
            HvF.AddCharacter(dwarf);
            HvF.AddCharacter(dwarf2);

            //HvF.FoesAttack();
            //HvF.HeroesAttack();
            HvF.DoEncounter();

            //Console.WriteLine(HvF.heroes[0].Name);
            //Console.WriteLine(HvF.foes[0].Name);



        }
    }
}
