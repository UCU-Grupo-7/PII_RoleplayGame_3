using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    public class HeroVSFoe : IEncounter
    {
        protected List<Hero> heroes = new List<Hero>();
        protected List<Foe> foes = new List<Foe>();
        public HeroVSFoe(/* List<Hero> heroes , List<Foe> foes */){
            /* this.heroes = heroes;
            this.foes = foes; */
            

        }

        public void DoEncounter(){
            while (heroes.Count!= 0 || foes.Count!=0)
            {
                FoesAttack();
                HeroesAttack();    
                if (heroes.Count == 0)
                {
                    Console.WriteLine("Foes Wins!");
                    break;
                }
                if (foes.Count == 0)
                {
                    Console.WriteLine("Heroes Wins!");
                    foreach (Hero hero in heroes)
                    {
                        hero.Cure();
                    }
                    break;
                }
            }
            



        }
        public void FoesAttack()
        {
            //if (foes.Count>heroes.Count){
                int j = 0;
                for (int i = 0; i < foes.Count; i++)
                {
                    if(heroes[j].Health == 0){ //si se muere el heroe, el enemigo no pierde el turno y ataca al siguiente heroe
                        i--;
                        j++;
                        if (j >= heroes.Count)
                        {
                        j=0;
                        }
                        continue;
                    }
                    foes[i].Attack(heroes[j]);
                    j++;
                    if (j >= heroes.Count){
                        j=0;
                    }
                }
                for (int i = 0; i < heroes.Count; i++)
                {
                    if (heroes[i].Health == 0)
                    {
                        RemoveCharacter(heroes[i]);
                    }
                }
            //}
/*             else
            {
                for (int i = 0; i < foes.Count; i++)  // aca corta en el ultimo enemigo
                    {
                        if (heroes[i].Health == 0){
                            i--;
                            continue;
                        }
                        foes[i].Attack(heroes[i]);
                    }
            } */

        }
        public void HeroesAttack()
        {
            foreach (Hero hero in heroes)
            {
                for (int i = 0; i < foes.Count; i++)
                {
                    if (foes[i].Health > 0)
                    {
                        hero.Attack(foes[i]);
                    }
                    if (foes[i].Health == 0)
                    {
                        RemoveCharacter(foes[i]);
                    }
                }
            }
        }
        public void AddCharacter(Character character)
        {
            if(character is Hero)
            {
                this.heroes.Add((Hero)character);
            }
            else if(character is Foe)
            {
                this.foes.Add((Foe)character);
            }
            else{
                Console.WriteLine("Character not Hero or Foe");
            }
        }

        public void RemoveCharacter(Character character)
        {
            if(character is Hero)
            {
                this.heroes.Remove((Hero)character);
            }
            else if(character is Foe)
            {
                this.foes.Remove((Foe)character);
            }
        }
    }
}

