using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class ClothArmorFactory
    {
        public static ICloth CreateHead(string name, int durability, int levelNeeded)
        {
            return new ClothHead(name, durability, levelNeeded);
        }
        public static ICloth CreateShoulder(string name, int durability, int levelNeeded)
        {
            return new ClothShoulder(name, durability, levelNeeded);
        }
    }
}
