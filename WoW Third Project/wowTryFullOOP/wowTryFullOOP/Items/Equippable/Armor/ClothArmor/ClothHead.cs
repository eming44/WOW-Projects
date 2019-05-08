using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class ClothHead : Head, ICloth
    {
        private int cloth = 2;
        public ClothHead(string name, int durability, int levelNeeded) : base(name, durability, levelNeeded)
        {
        }

        public int Cloth
        {
            get
            {
                return this.cloth;
            }
        }

        public void Equip(IHero hero)
        {
            MultiplierFromArmorKind = Cloth;
            base.Equip(hero);
        }
    }
}
