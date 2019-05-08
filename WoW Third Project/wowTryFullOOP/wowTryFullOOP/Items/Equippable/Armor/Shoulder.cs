using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public abstract class Shoulder : Armor, IShoulder
    {
        public Shoulder(string name, int durability, int levelNeeded) : base(name, durability, levelNeeded)
        {
            SlotCompatibility = 1;
        }

        public int SlotCompatibility
        {
            get
            {
                return base.SlotCompatibility;
            }
            private set
            {
                base.SlotCompatibility = value;
            }
        }

        public void Equip(IHero hero)
        {
            hero.Equippment[SlotCompatibility] = this;
            base.Equip(hero);
        }
    }
}
