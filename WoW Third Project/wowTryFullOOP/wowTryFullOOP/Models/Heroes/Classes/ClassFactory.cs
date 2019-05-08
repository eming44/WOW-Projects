using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace wowTryFullOOP
{
    public class ClassFactory
    {
        public static IWarriorHero CreateWarrior(string name)
        {
            double healthCap = 600;
            double armorCap = 100;
            double spellResistanceCap = 100;
            int damage = 60;
            int ExperienceCap = 1000;
            int agility = 40;
            int intellect = 30;
            int straight = 90;

            IUnityContainer conteiner = new UnityContainer();
            conteiner.RegisterType<Warrior>(new InjectionConstructor(new object[]
            {
                name,
                healthCap,
                PowerFactory.CreateRagePower(),
                //ClassFactory.CreateWarriorClass(),
                armorCap,
                spellResistanceCap,
                damage,
                ExperienceCap
            }));

            Warrior hero = conteiner.Resolve<Warrior>();
            hero.Agility = agility;
            hero.Intellect = intellect;
            hero.Straight = straight;
            hero.ClassKind = "Warrior";

            return hero;
        }
        public static IMageHero CreateMage(string name)
        {
            double healthCap = 500;
            double armorCap = 60;
            double spellResistanceCap = 60;
            int damage = 140;
            int ExperienceCap = 1000;
            int agility = 40;
            int intellect = 90;
            int straight = 30;

            IUnityContainer conteiner = new UnityContainer();
            conteiner.RegisterType<Mage>(new InjectionConstructor(new object[]
            {
                name,
                healthCap,
                PowerFactory.CreateRagePower(),
                //ClassFactory.CreateWarriorClass(),
                armorCap,
                spellResistanceCap,
                damage,
                ExperienceCap
            }));

            Mage hero = conteiner.Resolve<Mage>();
            hero.Agility = agility;
            hero.Intellect = intellect;
            hero.Straight = straight;
            hero.ClassKind = "Mage";

            return hero;
        }
    }
}
