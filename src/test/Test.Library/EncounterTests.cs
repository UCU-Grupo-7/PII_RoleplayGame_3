using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    public class EncounterTests
    {
        [SetUp]
        public void SetUp()
        {
        }

        [Test]
        public void HeroWins()
        {
            SpellsBook book2 = new SpellsBook();
            book2.AddSpell(new Fireball());
            book2.AddSpell(new Thunder());

            Hero gandalf = new Wizard("Gandalf");
            gandalf.AddItem(book2);
            gandalf.AddItem(new Staff());
            gandalf.AddItem(new Staff());

            Hero legolas = new Archer("Legolas");
            legolas.AddItem(new Bow());
            legolas.AddItem(new Bow());
            legolas.AddItem(new Bow());
            legolas.AddItem(new Bow());

            Foe goblin = new Goblin();

            HeroVsFoe encounter = new HeroVsFoe();
            enconter.AddCharacter(gandalf, goblin, legolas);

            Assert.That(encounter.foes[0].Name == "Goblin");
            Assert.That(encounter.heroes[0].Name == "Gandalf");
            Assert.That(encounter.heroes[1].Name == "Legolas");
        
            encounter.DoEncounter(); 
        
            Assert.That(encounter.DoEncounter(), "Heroes wins!");
        }
        public void Foes()
        {
            Hero knight = new Knight("Faramir");
            
            Foe goblin = new Goblin();
            Foe golem = new Golem();

            goblin.AddItem(new Axe());
            goblin.AddItem(new Axe());
            goblin.AddItem(new Axe());

            golem.AddItem(new Sword());
            golem.AddItem(new Sword());
            golem.AddItem(new Sword());

            HeroVsFoe encounter = new HeroVsFoe();
            encounter.AddCharacter(knight, goblin, golem);
            encounter.DoEncounter(); 
            

            Assert.That(encounter.foes[0].Name == "Goblin");
            Assert.That(encounter.heroes[0].Name == "Golem");
            Assert.That(encounter.heroes[1].Name == "Faramir");
            Assert.That(encounter.DoEncounter(), "Foes wins!");
        }
        
    }
}