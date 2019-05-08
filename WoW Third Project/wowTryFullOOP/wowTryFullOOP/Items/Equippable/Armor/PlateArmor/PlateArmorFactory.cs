using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class PlateArmorFactory
    {
        public static IPlate CreateHead(string name, int durability, int levelNeeded)
        {
            return new PlateHead(name, durability, levelNeeded);
        }
        public static IPlate CreateShoulder(string name, int durability, int levelNeeded)
        {
            return new PlateShoulder(name, durability, levelNeeded);
        }
    }
}
