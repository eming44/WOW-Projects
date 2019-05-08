using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public abstract class Heavy : Hero, IHeavy
    {
        public Heavy(
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

        public void BuffFromStraight()
        {
            int straight = Straight;
            int agility = Agility / 10;
            int intellect = Intellect / 10;

            BuffFromStats(straight, agility, intellect, straight);
        }
    }
}
