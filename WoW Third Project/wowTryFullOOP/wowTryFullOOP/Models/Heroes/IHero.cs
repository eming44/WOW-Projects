namespace wowTryFullOOP
{
    public interface IHero : ICharacter
    {
        int Agility { get; set; }
        int Straight { get; set; }
        int Intellect { get; set; }
        IEquippable<Item>[] Equippment { get; }
        Backpack Backpack { get; set; }

        //void Attack(ICharacter attacked);
        void Use(IUseable<Item> item);
        void Equip(IEquippable<Item> item);
    }
}