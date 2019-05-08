using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace wowTryFullOOP
{
    public class WarriorSpellFactory
    {
        public string ClassType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static ISpellCastTo CreateBloodLust()
        {
            return new BloodLust(40, 15, 1, 0);
        }
        public static ISpellCastTo CreateMortalStrike()
        {
            return new MortalStrike(100, 20, 1, 0);
        }
        public static ISpellCast CreateRecklessness()
        {
            return new Recklessness(100, 100, 1, 30);
        }
    }
}
