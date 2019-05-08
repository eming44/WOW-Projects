using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public abstract class Magical : Hero, IMagical
    {
        public Magical(
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

        public void BuffFromIntellect()
        {
            int straight = Straight / 10;
            int agility =  Agility / 10;
            int intellect = Intellect;

            BuffFromStats(straight, agility, intellect, intellect);
        }
    }
}
