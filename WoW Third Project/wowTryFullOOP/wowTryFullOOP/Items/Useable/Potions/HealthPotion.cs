using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class HealthPotion : Item, IUseable<Item>
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

        public HealthPotion(
            string name,
            int newLevelNeeded,
            int newValue) : base(name, 1, newLevelNeeded)
        {
            this.value = newValue;
        }

        public void Use(IHero character)
        {
            character.HealthCurr += this.value;
            if (character.HealthCurr > character.HealthCap)
            {
                character.HealthCurr = character.HealthCap;
            }
        }
    }
}
