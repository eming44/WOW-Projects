using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class ElixirOfAgility : Item, IUseable<Item>
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

        public ElixirOfAgility(
            string name,
            int LevelNeeded,
            int Value) : base(name, 1, LevelNeeded)
        {
            this.value = Value;
        }

        public void Use(IHero character)
        {
            character.Agility += this.value;
        }
    }
}
