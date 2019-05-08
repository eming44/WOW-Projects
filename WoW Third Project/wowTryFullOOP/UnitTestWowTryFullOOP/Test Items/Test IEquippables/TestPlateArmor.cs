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
    public class TestPlateArmor
    {
        [TestMethod]
        public void PlateHeadObject_ShouldIncreaseStats_WhenEquipped()
        {
            IWarriorHero hero = ClassFactory.CreateWarrior("Hero");
            int agility = hero.Agility;
            int straight = hero.Straight;
            int intellect = hero.Intellect;
            double armor = hero.Armor;

            IPlate head = PlateArmorFactory.CreateHead("head", 1, 1);
            head.Value = 1;
            head.Agility = 1;
            head.Stragiht = 1;
            head.Intellect = 1;

            hero.Equip(head);

            Assert.IsFalse(
                agility == hero.Agility
                && straight == hero.Straight
                && intellect == hero.Intellect
                && armor == hero.Armor);
        }
        [TestMethod]
        public void PlateShoulderObject_ShouldIncreaseStats_WhenEquipped()
        {
            IWarriorHero hero = ClassFactory.CreateWarrior("Hero");
            int agility = hero.Agility;
            int straight = hero.Straight;
            int intellect = hero.Intellect;
            double armor = hero.Armor;

            IPlate shoulder = PlateArmorFactory.CreateShoulder("shoulder", 1, 1);
            shoulder.Value = 1;
            shoulder.Agility = 1;
            shoulder.Stragiht = 1;
            shoulder.Intellect = 1;

            hero.Equip(shoulder);

            Assert.IsFalse(
                agility == hero.Agility
                && straight == hero.Straight
                && intellect == hero.Intellect
                && armor == hero.Armor);
        }
        [TestMethod]
        public void PlateHeadObject_ShouldNotBeEquippedByNONPlateClass_WhenEquipped()
        {
            IMageHero hero = ClassFactory.CreateMage("hero");
            int agility = hero.Agility;
            int straight = hero.Straight;
            int intellect = hero.Intellect;
            double armor = hero.Armor;

            IPlate head = PlateArmorFactory.CreateHead("head", 1, 1);
            head.Value = 1;
            head.Agility = 1;
            head.Stragiht = 1;
            head.Intellect = 1;

            hero.Equip(head);

            Assert.IsTrue(
                agility == hero.Agility
                && straight == hero.Straight
                && intellect == hero.Intellect
                && armor == hero.Armor);
        }
        [TestMethod]
        public void PlateShoulderObject_ShouldNotBeEquippedByNONPlateClass_WhenEquipped()
        {
            IMageHero hero = ClassFactory.CreateMage("hero");
            int agility = hero.Agility;
            int straight = hero.Straight;
            int intellect = hero.Intellect;
            double armor = hero.Armor;

            IPlate shoulder = PlateArmorFactory.CreateShoulder("shoulder", 1, 1);
            shoulder.Value = 1;
            shoulder.Agility = 1;
            shoulder.Stragiht = 1;
            shoulder.Intellect = 1;

            hero.Equip(shoulder);

            Assert.IsTrue(
                agility == hero.Agility
                && straight == hero.Straight
                && intellect == hero.Intellect
                && armor == hero.Armor);
        }
    }
}
