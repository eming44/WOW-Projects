namespace wowTryFullOOP
{
    public interface IUseable<T> : IBackpackable<Item>
    {
        int Value { get; set; }

        void Use(IHero character);
    }
}