using System.Collections.Generic;
using System.Timers;

namespace wowTryFullOOP
{
    public interface ICharacter
    {
        string Name { get; }
        double HealthCap { get; set; }
        double HealthCurr { get; set; }
        Timer HealthRegenTimer { get; set; }
        double HealthRegen { get; set; }
        IPower Power { get; set; }
        double Armor { get; set; }
        double SpellResistance { get; set; }
        int MissChance { get; set; }
        int Damage { get; set; }
        int CriticalChance { get; set; }
        double CriticalDamage { get; set; }
        bool IsAlive { get; set; }
        string ClassKind { get; set; }
        int Level { get; set; }
        List<ISpell> SpellBook { get; set; }

        void Attack(ICharacter attacked);
        //void cast(ISpellCast spell);
        // void castTo(ISpellCastTo spell, ICharacter target);
    }
}