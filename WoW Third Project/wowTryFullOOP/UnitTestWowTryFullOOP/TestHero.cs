using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using wowTryFullOOP;

namespace UnitTestWowTryFullOOP
{
    [TestClass]
    public class TestHero
    {
        [TestMethod]
        public void CastToMethod_ShouldMakeDamage_WhenCalled()
        {
            //Arrange
            IWarriorHero attacker = ClassFactory.CreateWarrior("Grommash");
            IWarriorHero attacked = ClassFactory.CreateWarrior("Varian");
            attacked.MissChance = 0;
            double attackedHealth = attacked.HealthCurr;
            //Act
            attacker.CastTo(WarriorSpellFactory.CreateBloodLust(), attacked);

            //Assert
            Assert.AreNotEqual(attackedHealth, attacked.HealthCurr);
        }

        [TestMethod]
        public void CastMethod_ShouldBuffYourself_WhenCalled()
        {
            IHero attacker = ClassFactory.CreateWarrior("Grommash");
            IHero attacked = ClassFactory.CreateWarrior("Varian");

        }

        [TestMethod]
        public void AttackMethod_ShouldMakeDamage_WhenCalled()
        {
            IHero attacker = ClassFactory.CreateWarrior("Grommash");
            attacker.Damage += 100;   //Damage too low and regeneration too fast for test
            IHero attacked = ClassFactory.CreateWarrior("Varian");
            attacked.MissChance = 0;
            attacked.HealthCap = 300;
            attacked.HealthCurr = attacked.HealthCap;

            attacker.Attack(attacked);

            Assert.IsTrue(attacked.HealthCurr > 150 && attacked.HealthCurr < 300);
        }

        [TestMethod]
        public void UseMethod_ShouldUseItem_WhenCalled()
        {
            IWarriorHero dummy = ClassFactory.CreateWarrior("test");
            dummy.HealthCurr = 1;
            double oldHealthCurr = dummy.HealthCurr;
            IUseable<Item> healthPotion = PotionFactory.CreateHealthPotion("test", 1, 50);

            dummy.Use(healthPotion);

            Assert.AreNotEqual(oldHealthCurr, dummy.HealthCurr);
        }

        [TestMethod]
        public void EquipMethod_ShouldEquipItem_WhenCalled()
        {
            IWarriorHero hero = ClassFactory.CreateWarrior("Hero");
            double armor = hero.Armor;
            double healthCap = hero.HealthCap;
            double healthRegen = hero.HealthRegen;
            int missChance = hero.MissChance;
            int criticalChance = hero.CriticalChance;
            double criticalDamage = hero.CriticalDamage;

            IEquippable<Item> shoulder = PlateArmorFactory.CreateShoulder("shoulder", 1, 1);
            shoulder.Value = 300;
            shoulder.Agility = 30;
            shoulder.Stragiht = 30;
            shoulder.Intellect = 30;


            hero.Equip(shoulder);


            Assert.IsTrue(
                armor != hero.Armor
                && healthCap != hero.HealthCap
                && healthRegen != hero.HealthRegen
                && missChance != hero.MissChance
                && criticalChance != hero.CriticalChance
                && criticalDamage != hero.CriticalDamage);
        }
    }
}
