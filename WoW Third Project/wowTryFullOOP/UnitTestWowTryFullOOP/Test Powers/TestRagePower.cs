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
    public class TestRagePower
    {
        [TestMethod]
        public void PowerConsumeMethod_ShouldConsumeAmountOfRagePower_WhenCalled()
        {
            IPower ragePower = PowerFactory.CreateRagePower();
            ragePower.PowerCurr = 100;
            ISpell spell = WarriorSpellFactory.CreateMortalStrike();
            spell.PowerCost = 50;

            ragePower.PowerConsume(spell);

            Assert.AreEqual(ragePower.PowerCurr, 50);
        }
        [TestMethod]
        public void PowerGenerateMethod_ShouldGenerateAmountOfRagePower_WhenCalled()
        {
            IPower ragePower = PowerFactory.CreateRagePower();
            ISpell spell = WarriorSpellFactory.CreateBloodLust();

            ragePower.PowerGenerate(spell);

            Assert.AreNotEqual(ragePower.PowerCurr, 0);
        }
    }
}
