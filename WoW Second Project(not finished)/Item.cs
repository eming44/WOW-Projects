using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Item
    {
        private Classes itemClass;
        //private int power = 1;
        private string name;
        private int itemValue;
        private int itemLevel;
        private KindOfItem kindOfItem;
        private KindOfWeapon kindOfWeapon;
        private KindOfArmory kindOfArmory;
        private ArmorMaterial armorMaterial;
        private KindOfPotion kindOfPotion;
        public string NameGetSet
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public KindOfItem KindOfItemGet
        {
            get
            {
                return this.kindOfItem;
            }
        }
        public KindOfPotion KindOfPotionGet
        {
            get
            {
                return this.kindOfPotion;
            }
        }
        public int ItemValueGetSet
        {
            get
            {
                return this.itemValue;
            }
            set
            {
                this.itemValue = value;
            }
        }
        public int ItemLevelGetSet
        {
            get
            {
                return this.itemLevel;
            }
            set
            {
                this.itemLevel = value;
            }
        }
        public KindOfWeapon KindOfWeaponGetSet
        {
            get
            {
                return this.kindOfWeapon;
            }
            set
            {
                this.kindOfWeapon = value;
            }
        }
        public ArmorMaterial ArmorMaterialGetSet
        {
            get
            {
                return this.armorMaterial;
            }
            set
            {
                this.armorMaterial = value;
            }
        }
        public enum KindOfItem
        {
            Weapon,
            Armory,
            Potion
        }
        public enum KindOfPotion
        {
            Health,
            Mana
        }
        public enum KindOfWeapon
        {
            Axe,
            Hammer,
            Sword,
            Bow,
            Polearm,
            Daggers,
            Staff,
            FistWeapon,
            TwinBlades
        }
        public enum KindOfArmory
        {
            Head,
            Sholders,
            Chest,
            Hands,
            Legs,
            Feet
        }
        public enum ArmorMaterial
        {
            Plate,
            Mail,
            Cloth,
            Leather
        }
        public Item(
            KindOfItem newKindOfItem,
            KindOfWeapon newKindOfWeapon,
            string newName = "Common weapon")
        {
            this.name = newName;
            this.kindOfWeapon = newKindOfWeapon;
            this.kindOfItem = newKindOfItem;
            this.itemLevel = 1;
            if (kindOfWeapon.Equals(KindOfWeapon.Axe) && kindOfItem.Equals(KindOfItem.Weapon))
            {
                this.itemValue = 60;
            }
            else if (kindOfWeapon.Equals(KindOfWeapon.Sword) && kindOfItem.Equals(KindOfItem.Weapon))
            {
                this.itemValue = 50;
            }
            else if (kindOfWeapon.Equals(KindOfWeapon.Hammer) && kindOfItem.Equals(KindOfItem.Weapon))
            {
                this.itemValue = 55;
            }
            else if (kindOfWeapon.Equals(KindOfWeapon.Bow) && kindOfItem.Equals(KindOfItem.Weapon))
            {
                this.itemValue = 56;
            }
            else if (kindOfWeapon.Equals(KindOfWeapon.Daggers) && kindOfItem.Equals(KindOfItem.Weapon))
            {
                this.itemValue = 52;
            }
            else if (kindOfWeapon.Equals(KindOfWeapon.FistWeapon) && kindOfItem.Equals(KindOfItem.Weapon))
            {
                this.itemValue = 54;
            }
            else if (kindOfWeapon.Equals(KindOfWeapon.Polearm) && kindOfItem.Equals(KindOfItem.Weapon))
            {
                this.itemValue = 58;
            }
            else if (kindOfWeapon.Equals(KindOfWeapon.Staff) && kindOfItem.Equals(KindOfItem.Weapon))
            {
                this.itemValue = 56;
            }
            else if (kindOfWeapon.Equals(KindOfWeapon.TwinBlades) && kindOfItem.Equals(KindOfItem.Weapon))
            {
                this.itemValue = 19;
            }
        }

        public Item(
            KindOfItem newKindOfItem,
            KindOfArmory newKindOfArmory,
            Classes newItemClass)
        {
            this.itemClass = newItemClass;
            this.kindOfItem = newKindOfItem;
            this.kindOfArmory = newKindOfArmory;
            this.itemLevel = 1;
            if (itemClass.CharacterClass.Equals(new Classes(Classes.Class.Warrior).CharacterClass)
                || itemClass.CharacterClass.Equals(new Classes(Classes.Class.Paladin).CharacterClass)
                || itemClass.CharacterClass.Equals(new Classes(Classes.Class.DeathKnight).CharacterClass))
            {
                this.armorMaterial = ArmorMaterial.Plate;
                this.itemValue = 200;
            }
            else if (itemClass.CharacterClass.Equals(new Classes(Classes.Class.Hunter).CharacterClass)
                     || itemClass.CharacterClass.Equals(new Classes(Classes.Class.Druid).CharacterClass)
                     || itemClass.CharacterClass.Equals(new Classes(Classes.Class.Shaman).CharacterClass))
            {
                this.armorMaterial = ArmorMaterial.Mail;
                this.itemValue = 80;
            }
            else if (itemClass.CharacterClass.Equals(new Classes(Classes.Class.Monk).CharacterClass)
                     || itemClass.CharacterClass.Equals(new Classes(Classes.Class.DemonHunter).CharacterClass)
                     || itemClass.CharacterClass.Equals(new Classes(Classes.Class.Rouge).CharacterClass))
            {
                this.armorMaterial = ArmorMaterial.Leather;
                this.itemValue = 60;
            }
            else if (itemClass.CharacterClass.Equals(new Classes(Classes.Class.Mage).CharacterClass)
                     || itemClass.CharacterClass.Equals(new Classes(Classes.Class.Warlock).CharacterClass)
                     || itemClass.CharacterClass.Equals(new Classes(Classes.Class.Priest).CharacterClass))
            {
                this.armorMaterial = ArmorMaterial.Cloth;
                this.itemValue = 40;
            }
        }

        public Item(
            KindOfItem newKindOfItem,
            KindOfPotion newKindOfPotion
            )
        {
            this.kindOfItem = newKindOfItem;
            this.kindOfPotion = newKindOfPotion;
            if (kindOfPotion.Equals(KindOfPotion.Health))
            {
                this.itemValue = 100;
                this.name = "Health potion";
                //this.power++;
            }
            else if (kindOfPotion.Equals(KindOfPotion.Mana))
            {
                this.itemValue = 150;
                this.name = "Mana potion";
                //this.power++;
            }
        }
    }
}
