using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class Mage : Magical, IMagical, IMageHero
    {
        private bool isMage;

        public bool IsMage
        {
            get
            {
                return this.isMage;
            }
            private set
            {
                this.isMage = true;
            }
        }

        public Mage(
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

        public void Equip(IEquippable<Item> item)
        {
            try
            {
                if (Check.IsEquippableByMage(item) == true
                    && CheckMultiCast.ChechEquippability(this, item) == true)
                {
                    base.Equip(item);
                    ResetCharacterToDefault(500);
                    BuffFromIntellect();
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
