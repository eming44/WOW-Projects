using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class ElixirFactory
    {
        public static IUseable<Item> CreateElixirOfAgility(string name, int levelNeeded, int value)
        {
            return new ElixirOfAgility(name, levelNeeded, value);
        }
        public static IUseable<Item> CreateElixirOfStraight(string name, int levelNeeded, int value)
        {
            return new ElixirOfStraight(name, levelNeeded, value);
        }
        public static IUseable<Item> CreateElixirOfIntellect(string name, int levelNeeded, int value)
        {
            return new ElixirOfIntellect(name, levelNeeded, value);
        }
    }
}
