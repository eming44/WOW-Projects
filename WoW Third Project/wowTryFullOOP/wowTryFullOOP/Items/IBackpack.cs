namespace wowTryFullOOP
{
    public interface IBackpack<T> : IBackpackable<Item>
    {
        void Add(IBackpackable<Item> item);
        void Change(IEquippable<Item> itemEquipped, IEquippable<Item> itemInBackpack, IHero hero);
        void ShowBackpack();
    }
}