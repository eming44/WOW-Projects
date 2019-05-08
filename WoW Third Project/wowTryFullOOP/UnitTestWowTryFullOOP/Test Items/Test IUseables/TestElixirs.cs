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
    public class TestElixirs
    {
        [TestMethod]
        public void ElixirOfStraightObject_ShouldIncreaseStraightOfHero_WhenUsed()
        {
            IWarriorHero dummy = ClassFactory.CreateWarrior("test");
            int straight = dummy.Straight;
            IUseable<Item> elixir = ElixirFactory.CreateElixirOfStraight("test", 1, 10);

            dummy.Use(elixir);

            Assert.AreNotEqual(dummy.Straight, straight);
        }
        [TestMethod]
        public void ElixirOfAgilityObject_ShouldIncreaseAgilityOfHero_WhenUsed()
        {
            IWarriorHero dummy = ClassFactory.CreateWarrior("test");
            int agility = dummy.Agility;
            IUseable<Item> elixir = ElixirFactory.CreateElixirOfAgility("test", 1, 10);

            dummy.Use(elixir);

            Assert.AreNotEqual(dummy.Agility, agility);
        }
        [TestMethod]
        public void ElixirOfIntellectObject_ShouldIncreaseIntellectOfHero_WhenUsed()
        {
            IWarriorHero dummy = ClassFactory.CreateWarrior("test");
            int intellect = dummy.Intellect;
            IUseable<Item> elixir = ElixirFactory.CreateElixirOfIntellect("test", 1, 10);

            dummy.Use(elixir);

            Assert.AreNotEqual(dummy.Intellect, intellect);
        }
    }
}
