using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using wowTryFullOOP;

namespace UnitTestWowTryFullOOP.Test_Items
{
    [TestClass]
    public class TestPotions
    {
        [TestMethod]
        public void HealthPotionObject_ShouldIncreaseHealth_WhenUsed()
        {
            IWarriorHero dummy = ClassFactory.CreateWarrior("test");
            dummy.HealthCurr = 50;
            IUseable<Item> potion = PotionFactory.CreateHealthPotion("test", 1, 50);

            dummy.Use(potion);

            Assert.AreEqual(dummy.HealthCurr, 100);
        }
    }
}
