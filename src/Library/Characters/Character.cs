namespace RoleplayGame
{
    public abstract class Character : ICharacter
    {
        string Name { get; set; }

        int Health { get; }

        int AttackValue { get; }

        int DefenseValue { get; }

        void AddItem(IItem item);

        void RemoveItem(IItem item);

        void Cure();

        void Attack(ICharacter character);
    }
}