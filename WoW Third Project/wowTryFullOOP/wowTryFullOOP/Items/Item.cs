using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public abstract class Item : IItem
    {
        private string name;
        private int durability;
        private int levelNeeded;

        public string Name
        {
            get
            {
                return this.name;
            }
            
        }
        public int LevelNeeded
        {
            get
            {
                return this.levelNeeded;
            }
        }

        public Item(
            string name,
            int durability,
            int levelNeeded)
        {
            this.name = name;
            this.durability = durability;
            this.levelNeeded = levelNeeded;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
