namespace wowTryFullOOP
{
    public interface IMageHero : IMagical, IMage
    {
        void Equip(IEquippable<Item> item);
    }
}