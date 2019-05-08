using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using wowTryFullOOP;

namespace UnitTestWowTryFullOOP
{
    [TestClass]
    public class TestMortalStrike
    {
        [TestMethod]
        public void MortalStrikeSpell_ShouldMakeDamage_WhenCasted()
        {
            IWarriorHero hero = ClassFactory.CreateWarrior("Grommash");
            hero.Power.PowerCurr = 100;
            IWarriorHero dummy = ClassFactory.CreateWarrior("test");
            dummy.MissChance = 0;
            double health = dummy.HealthCurr;

            hero.CastTo(WarriorSpellFactory.CreateMortalStrike(), dummy);

            Assert.AreEqual(dummy.HealthCurr, health - WarriorSpellFactory.CreateMortalStrike().Value);
        }
        [TestMethod]
        public void MortalStrikeSpell_ShouldConsumeRage_WhenCasted()
        {
            IWarriorHero hero = ClassFactory.CreateWarrior("test");
            hero.Power.PowerCurr += 100;
            double amount = hero.Power.PowerCurr;

            IWarriorHero dummy = ClassFactory.CreateWarrior("test");
            dummy.MissChance = 0;


            hero.CastTo(WarriorSpellFactory.CreateMortalStrike(), dummy);


            Assert.AreNotEqual(amount, hero.Power.PowerCurr);
        }
    }
}
