namespace wowTryFullOOP
{
    public interface IWarriorHero : IHeavy, IWarrior
    {
        void Cast(ISpellCast spell);
        void CastTo(ISpellCastTo spell, ICharacter target);
        void Equip(IEquippable<Item> item);
    }
}