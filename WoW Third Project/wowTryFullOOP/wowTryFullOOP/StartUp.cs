using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;



namespace wowTryFullOOP
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var garrosh = ClassFactory.CreateWarrior("Garrosh");
            var khadgar = ClassFactory.CreateMage("Khadgar");
            //var head = ClothArmorFactory.CreateHead("helmet", 100, 1);

            //khadgar.Equip(head);

            garrosh.Attack(khadgar);
            garrosh.Attack(khadgar);
            garrosh.CastTo(WarriorSpellFactory.CreateBloodLust(), khadgar);




        }
    }
}
