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
    public class TestRecklessness
    {
        [TestMethod]
        public void RecklessnessSpell_ShouldHealHero_WhenCasted()
        {
            IWarriorHero hero = ClassFactory.CreateWarrior("test");
            hero.HealthCurr = 1;
            double health = hero.HealthCurr;

            hero.Cast(WarriorSpellFactory.CreateRecklessness());

            Assert.AreNotEqual(health, hero.HealthCurr);
        }
        [TestMethod]
        public void RecklessnessSpell_ShouldGenerateRage_WhenCasted()
        {
            IWarriorHero hero = ClassFactory.CreateWarrior("test");
            double amount = hero.Power.PowerCurr;

            hero.Cast(WarriorSpellFactory.CreateRecklessness());

            Assert.AreNotEqual(amount, hero.Power.PowerCurr);
        }
        //[TestMethod]
        //public void RecklessnessSpell_ShouldBeOnCoolDown_WhenCasted()
        //{
        //    IWarriorHero hero = ClassFactory.CreateWarrior("test");
        //    hero.HealthCurr = 1;
        //    double health = 0;
        //    double healthAfterSpellCasted = 0;
        //
        //    ISpellCast spell = WarriorSpellFactory.CreateRecklessness();
        //
        //    hero.Cast(spell);
        //    health = hero.HealthCurr;
        //    hero.Cast(spell);
        //    healthAfterSpellCasted = hero.HealthCurr;
        //
        //    Assert.AreEqual(health, healthAfterSpellCasted);
        //}
    }
}
