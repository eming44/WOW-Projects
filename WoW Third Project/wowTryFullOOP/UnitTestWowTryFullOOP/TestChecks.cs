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
    public class TestChecks
    {
        [TestMethod]
        public void LevelIsHigherOrEqualMethod_ShouldReturnTrue_WhenCalled()
        {
            ICharacter dummy = ClassFactory.CreateWarrior("test");
            dummy.Level = 10;
            int levelForChecks = 10;

            Assert.IsTrue(Check.LevelIsHigherOrEqual(dummy, levelForChecks));
            Assert.IsFalse(Check.LevelIsHigherOrEqual(dummy, 15));
        }
        [TestMethod]
        public void IsAliveMethod_ShouldReturnFalseIfCharacterIsDead_WhenCalled()
        {
            // ICharacter dummy = HeroFactory.CreateTestDummy();
            IWarriorHero dummy = ClassFactory.CreateWarrior("test");
            dummy.IsAlive = false;

            Assert.IsFalse(Check.IsAlive(dummy));
        }
        [TestMethod]
        public void MissChanceMethod_ShouldReturnTrueIfMissAttack_WhenCalled()
        {
            IHero hero = ClassFactory.CreateWarrior("hero");
            hero.Damage += 100;
            IHero dummy = ClassFactory.CreateWarrior("test");
            dummy.MissChance = 100; //100% Miss Chance
            double health = dummy.HealthCurr;

            hero.Attack(dummy);

            Assert.AreEqual(health, dummy.HealthCurr);
        }
    }
}
