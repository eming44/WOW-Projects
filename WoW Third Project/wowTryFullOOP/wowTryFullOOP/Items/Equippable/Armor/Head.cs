using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public abstract class Head : Armor, IHead
    {
        public Head(string name, int durability, int levelNeeded) : base(name, durability, levelNeeded)
        {
            SlotCompatibility = 0;
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
