using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public abstract class Armor : Item, IEquippable<Item>
    {
        private int value;
        private int straight;
        private int agility;
        private int intellect;
        private int multiplierFromArmorKind;
        private int slotCompatibility;

        public Armor(string name, int durability, int levelNeeded) : base(name, durability, levelNeeded)
        {
        }

        public int Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
        public int Stragiht
        {
            get
            {
                return this.straight;
            }
            set
            {
                this.straight = value;
            }
        }
        public int Agility
        {
            get
            {
                return this.agility;
            }
            set
            {
                this.agility = value;
            }
        }
        public int Intellect
        {
            get
            {
                return this.intellect;
            }
            set
            {
                this.intellect = value;
            }
        }
        public int MultiplierFromArmorKind
        {
            get
            {
                return this.multiplierFromArmorKind;
            }
            set
            {
                this.multiplierFromArmorKind = value;
            }
        }
        public int SlotCompatibility
        {
            get
            {
                return this.slotCompatibility;
            }
            set
            {
                this.slotCompatibility = value;
            }
        }

        public void Equip(IHero hero)
        {
            hero.Armor += Value * MultiplierFromArmorKind;
            hero.Straight += Stragiht;
            hero.Agility += Agility;
            hero.Intellect += Intellect;
        }

        public void UnEquip(IHero hero)
        {
            hero.Armor -= Value * MultiplierFromArmorKind;
            hero.Straight -= Stragiht;
            hero.Agility -= Agility;
            hero.Intellect -= Intellect;
        }
    }
}
