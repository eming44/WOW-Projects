using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class PotionFactory
    {
        public static IUseable<Item> CreateHealthPotion(string name, int levelNeeded, int value)
        {
            return new HealthPotion(name, levelNeeded, value);
        }
        public static IUseable<Item> CreateManaPotion(string name, int levelNeeded, int value)
        {
            return new ManaPotion(name, levelNeeded, value);
        }
    }
}
