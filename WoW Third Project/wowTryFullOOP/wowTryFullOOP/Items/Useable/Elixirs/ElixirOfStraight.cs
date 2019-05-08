using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class ElixirOfStraight : Item, IUseable<Item>
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

        public ElixirOfStraight(
            string name,
            int LevelNeeded,
            int Value) : base(name, 1, LevelNeeded)
        {
            this.value = Value;
        }

        public void Use(IHero character)
        {
            character.Straight += this.value;
        }
    }
}
