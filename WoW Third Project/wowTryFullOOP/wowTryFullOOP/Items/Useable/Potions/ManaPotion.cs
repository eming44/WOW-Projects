using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class ManaPotion : Item, IUseable<Item>
    {
        private int value;

        public int Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        public ManaPotion(
            string name,
            int newLevelNeeded,
            int newValue) : base(name, 1, newLevelNeeded)
        {
            this.value = newValue;
        }

        public void Use(IHero character)
        {
            //character.//Power.PowerCurr += this.value;
            //if (character.Power.PowerCurr > character.Power.PowerCap)
            //{
            //    character.Power.PowerCurr = character.Power.PowerCap;
            //}
        }
    }
}
