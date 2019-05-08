using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public abstract class Hero : Character, IHero
    {
        //Stats-------------------------------
        private int agility;
        private int straight;
        private int intellect;
        //Equippment slots--------------------
        private IEquippable<Item>[] equippment = new IEquippable<Item>[2];
        //Backpack and backpack slots---------
        public Backpack backpack;
        //private IBackpack<Item>[] backpackSlot1;
        //private IBackpack<Item>[] backpackSlot2;
        //private IBackpack<Item>[] backpackSlot3;

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
        public int Straight
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
        public IEquippable<Item>[] Equippment
        {
            get
            {
                return this.equippment;
            }
        }
        public Backpack Backpack
        {
            get
            {
                return this.backpack;
            }
            set
            {
                this.backpack = value;
            }
        }

        public Hero(string name,
            double healthCap,
            IPower power,
            double armorCap,
            double spellResistanceCap,
            int damage,
            int experienceCap)
                : base(name,
                        healthCap,
                        power,
                        armorCap,
                        spellResistanceCap,
                        damage,
                        experienceCap)
        {
            this.backpack = new Backpack(16);
        }

        public void Use(IUseable<Item> item)
        {
            try
            {
                if (Check.IsAlive(this) == true)
                {
                    item.Use(this);
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            catch (InvalidOperationException) { }
        }
        public void Equip(IEquippable<Item> item)
        {
            try
            {
                if (CheckMultiCast.ChechEquippability(this, item) == true)
                {
                    if (this.equippment[item.SlotCompatibility] != null)
                    { 
                        this.equippment[item.SlotCompatibility].UnEquip(this);
                        backpack.Change(this.equippment[item.SlotCompatibility], item, this);
                    }
                    else
                    {
                        item.Equip(this);
                    }
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            catch (InvalidOperationException) { }
        }
        protected virtual void BuffFromStats(int straight, int agility, int intellect, int mainStat)
        {
            HealthCap += straight;
            HealthCurr = HealthCap;

            MissChance += agility;
            HealthRegen += agility;

            CriticalChance += intellect;
            CriticalDamage += intellect;
            Power.PowerCap += intellect;
        }      
        protected void ResetCharacterToDefault(double healthCap)
        {
            base.HealthCap = healthCap;
            base.HealthRegen = 1.5;
            base.MissChance = 5;
            base.CriticalChance = 15;
            base.CriticalDamage = 20;
        }
    }
}
