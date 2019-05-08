using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class PlateHead : Head, IPlate
    {
        private int plate = 5;
        public PlateHead(string name, int durability, int levelNeeded) : base(name, durability, levelNeeded)
        {
        }

        public int Plate
        {
            get
            {
                return this.plate;
            }
        }

        public void Equip(IHero hero)
        {
            MultiplierFromArmorKind = Plate;
            base.Equip(hero);
        }
    }
}
