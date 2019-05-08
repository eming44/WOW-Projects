namespace wowTryFullOOP
{
    public interface IPower
    {
        double PowerCap { get; set; }
        double PowerCurr { get; set; }

        void PowerConsume(ISpell spell);
        void PowerGenerate(ISpell spell);
    }
}