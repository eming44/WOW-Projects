using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class Warrior : Heavy, IHeavy, IWarriorHero
    {
        private bool isWarrior;

        public bool IsWarrior
        {
            get
            {
                return this.isWarrior;
            }
            private set
            {
                this.isWarrior = true;
            }
        }

        public Warrior(
            string name,
            double healthCap, 
            IPower power, 
            double armorCap,
            double spellResistanceCap,
            int damage,
            int experienceCap) 
            : base(
                  name, 
                  healthCap,
                  power, 
                  armorCap, 
                  spellResistanceCap, 
                  damage, 
                  experienceCap)
        {
        }

        public void Cast(ISpellCast spell)
        {
            try
            {
                if (Check.IsCastableByWarrior(this, spell) == true)
                {
                    base.Cast(spell);
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            catch (InvalidOperationException) { }
        }

        public void CastTo(ISpellCastTo spell, ICharacter target)
        {
            try
            {
                if (Check.IsCastableByWarrior(this, spell) == true)
                {
                    base.CastTo(spell, target);
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            catch (InvalidOperationException) { }
        }

        public void Equip(IEquippable<Item> item)
        {
            try
            {
                if (Check.IsEquippableByWarrior(item) == true 
                    && CheckMultiCast.ChechEquippability(this, item) == true)
                {
                    base.Equip(item);
                    ResetCharacterToDefault(600);
                    BuffFromStraight();
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            catch (InvalidOperationException) { }
        }
    }
}
