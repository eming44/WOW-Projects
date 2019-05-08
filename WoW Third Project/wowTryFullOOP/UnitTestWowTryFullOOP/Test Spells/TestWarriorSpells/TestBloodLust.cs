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
    public class TestBloodLust
    {
        [TestMethod]
        public void BloodLustSpell_ShouldMakeDamage_WhenCasted()
        {
            IWarriorHero hero = ClassFactory.CreateWarrior("Grommash");
            IWarriorHero dummy = ClassFactory.CreateWarrior("test");
            dummy.MissChance = 0;
            double health = dummy.HealthCurr;

            hero.CastTo(WarriorSpellFactory.CreateBloodLust(), dummy);

            Assert.AreEqual(dummy.HealthCurr, health - WarriorSpellFactory.CreateBloodLust().Value);
        }
        [TestMethod]
        public void BloodLustSpell_ShouldGenerateRage_WhenCasted()
        {
            IWarriorHero hero = ClassFactory.CreateWarrior("test");
            double amount = hero.Power.PowerCurr;

            IWarriorHero dummy = ClassFactory.CreateWarrior("test");
            dummy.MissChance = 0;


            hero.CastTo(WarriorSpellFactory.CreateBloodLust(), dummy);


            Assert.AreNotEqual(amount, hero.Power.PowerCurr);
        }
    }
}
