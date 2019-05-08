namespace wowTryFullOOP
{
    public interface ISpell : ICoolDownable
    {
        string Name { get; }
        int LevelRequired { get; set; }
        double Value { get; set; }
        double PowerCost { get; set; }
    }
}