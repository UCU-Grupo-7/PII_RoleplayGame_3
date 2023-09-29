using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.AddSpell(new Fireball());
            book.AddSpell(new Thunder());

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.AddItem(book); 

            Dwarf gimli = new Dwarf("Gimli");

            Archer legolas = new Archer("Legolas");

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with ⚔️ {gandalf.AttackValue}");

            //gimli.ReceiveAttack(gandalf.AttackValue);
            legolas.Attack(gandalf);

            Console.WriteLine($"Gimli has ❤️ {gimli.Health}");
            Console.WriteLine($"Legolas has ❤️ {legolas.Health}");
            Console.WriteLine($"gandalf has ❤️ {gandalf.Health}");

            gimli.Cure();
            legolas.Cure();

            Console.WriteLine($"Someone cured Gimli. Gimli now has ❤️ {gimli.Health}");
            Console.WriteLine($"Someone cured Legolas. Legolas now has ❤️ {legolas.Health}");
        }
    }
}
