using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowAgain
{
    class Character
    {
        //Cosmetics----------------------------
        private string userName;
        private Hair hair;
        private Eyes eyes;
        private BodyAndSkin bodyAndSkin;
        private FactionRaceGender factionRaceGender;
        private Classes characterClass;
        private bool checkHero = false;
        //Stats--------------------------------
        private int health;
        private int healthCap;
        private int mana;
        private int manaCap;
        private int armor = 80;
        private int armorCap;
        private int level = 1;
        private int experience = 0;
        private int experienceCap = 100;
        private int itemLevel;
        private int damage; //For Mobs & Bosses
        //Equipment----------------------------
        private Item weapon;
        private Item head;
        private Item shoulders;
        private Item hands;
        private Item chest;
        private Item legs;
        private Item feet;
        private int gold;
        public Item WeaponGet
        {
            get
            {
                return this.weapon;
            }
        }
        public int GoldGetSet
        {
            get
            {
                return this.gold;
            }
            set
            {
                this.gold = value;
            }
        }
        public int HealthGetSet
        {
            get
            {
                return this.health;
            }
            set
            {
                this.healthCap = value;
                this.health = this.healthCap;
            }
        }
        public int DamageGet
        {
            get
            {
                return this.damage;
            }
        }
        public int ArmorGetSet
        {
            get
            {
                return this.armor;
            }
            set
            {
                this.armor = value;
            }
        }
        public int ArmorCapGet
        {
            get
            {
                return this.armorCap;
            }
        }
        public List<Spells> SpellBookGet
        {
            get
            {
                return this.spellBook;
            }
        }
        public string UserNameGet
        {
            get
            {
                return this.userName;
            }
        }
        public int LevelGet
        {
            get
            {
                return this.level;
            }
        }

        //Create Hero-------------------------
        public Character(
            string newUserName,
            Hair newHair,
            Eyes newEyes,
            BodyAndSkin newBodyAndSkin,
            FactionRaceGender newFaction,
            Classes newCharacterClass
            )
        {
            this.userName = newUserName;
            this.hair = newHair;
            this.eyes = newEyes;
            this.bodyAndSkin = newBodyAndSkin;
            this.factionRaceGender = newFaction;
            this.characterClass = newCharacterClass;
            this.checkHero = true;

           

            //Setting weapon----------------------------------------------------------------------------------------------
            if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.Warrior).CharacterClass))
            {
                this.weapon = new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe);
                spellBook.Add(new Spells(Spells.Warrior.HeroicStrike));
                spellBook.Add(new Spells(Spells.Warrior.Execute));
                spellBook.Add(new Spells(Spells.Warrior.GladiatorRage));
                //-----------------
                health = 400;
                healthCap = health;
                mana = 400;
                manaCap = mana;
                this.weapon.ItemValueGetSet += 0;
            }
            else if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.DeathKnight).CharacterClass))
            {
                this.weapon = new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Sword);
                spellBook.Add(new Spells(Spells.DeathKnight.DeathStrike));
                spellBook.Add(new Spells(Spells.DeathKnight.Lifesteal));
                spellBook.Add(new Spells(Spells.DeathKnight.ArmyOfTheDead));
                //-----------------
                health = 400;
                healthCap = health;
                mana = 400;
                manaCap = mana;
                this.weapon.ItemValueGetSet += 0;
            }
            else if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.Paladin).CharacterClass))
            {
                this.weapon = new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Hammer);
                spellBook.Add(new Spells(Spells.Paladin.DivineShield));
                spellBook.Add(new Spells(Spells.Paladin.Judgment));
                spellBook.Add(new Spells(Spells.Paladin.AvengingWrath));
                //-----------------
                health = 400;
                healthCap = health;
                mana = 400;
                manaCap = mana;
                this.weapon.ItemValueGetSet += 0;
            }
            else if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.DemonHunter).CharacterClass))
            {
                this.weapon = new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.TwinBlades);
                spellBook.Add(new Spells(Spells.DemonHunter.DemonSkin));
                spellBook.Add(new Spells(Spells.DemonHunter.DoubleSlash));
                spellBook.Add(new Spells(Spells.DemonHunter.DemonicInfusion));
                //-----------------
                health = 400;
                healthCap = health;
                mana = 500;
                manaCap = mana;
                this.weapon.ItemValueGetSet += 110;
            }
            else if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.Druid).CharacterClass))
            {
                this.weapon = new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Staff);
                spellBook.Add(new Spells(Spells.Druid.Regrowth));
                spellBook.Add(new Spells(Spells.Druid.Swipe));
                spellBook.Add(new Spells(Spells.Druid.StarFire));
                //-----------------
                health = 800;
                healthCap = health;
                mana = 500;
                manaCap = mana;
                this.weapon.ItemValueGetSet += 0;
            }
            else if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.Mage).CharacterClass))
            {
                this.weapon = new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Staff);
                spellBook.Add(new Spells(Spells.Mage.FireBall));
                spellBook.Add(new Spells(Spells.Mage.PyroBlast));
                spellBook.Add(new Spells(Spells.Mage.LivingBomb));
                //-----------------
                health = 400;
                healthCap = health;
                mana = 1000;
                manaCap = mana;
                this.weapon.ItemValueGetSet += 0;
            }
            else if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.Warlock).CharacterClass))
            {
                this.weapon = new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Staff);
                spellBook.Add(new Spells(Spells.Warlock.ChaosBolt));
                spellBook.Add(new Spells(Spells.Warlock.DrainLife));
                spellBook.Add(new Spells(Spells.Warlock.SacrificeDemon));
                //-----------------
                health = 400;
                healthCap = health;
                mana = 1000;
                manaCap = mana;
                this.weapon.ItemValueGetSet += 0;
            }
            else if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.Priest).CharacterClass))
            {
                this.weapon = new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Staff);
                spellBook.Add(new Spells(Spells.Priest.Heal));
                spellBook.Add(new Spells(Spells.Priest.Smite));
                spellBook.Add(new Spells(Spells.Priest.MindControl));
                //-----------------
                health = 400;
                healthCap = health;
                mana = 1000;
                manaCap = mana;
                this.weapon.ItemValueGetSet += 0;
            }
            else if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.Hunter).CharacterClass))
            {
                this.weapon = new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Bow);
                spellBook.Add(new Spells(Spells.Hunter.SteadyShot));
                spellBook.Add(new Spells(Spells.Hunter.FireTrap));
                spellBook.Add(new Spells(Spells.Hunter.ChimeraShot));
                //-----------------
                health = 400;
                healthCap = health;
                mana = 500;
                manaCap = mana;
                this.weapon.ItemValueGetSet += 100;
            }
            else if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.Monk).CharacterClass))
            {
                this.weapon = new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Polearm);
                spellBook.Add(new Spells(Spells.Monk.BlackoutKick));
                spellBook.Add(new Spells(Spells.Monk.FlyingSerpentKick));
                spellBook.Add(new Spells(Spells.Monk.Meditaion));
                //-----------------
                health = 800;
                healthCap = health;
                mana = 500;
                manaCap = mana;
                this.weapon.ItemValueGetSet += 0;
            }
            else if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.Shaman).CharacterClass))
            {
                this.weapon = new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.FistWeapon);
                spellBook.Add(new Spells(Spells.Shaman.LavaBurst));
                spellBook.Add(new Spells(Spells.Shaman.LightningBolt));
                spellBook.Add(new Spells(Spells.Shaman.Vulcano));
                //-----------------
                health = 800;
                healthCap = health;
                mana = 500;
                manaCap = mana;
                this.weapon.ItemValueGetSet += 0;
            }
            else if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.Rouge).CharacterClass))
            {
                this.weapon = new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Daggers);
                spellBook.Add(new Spells(Spells.Rogue.Backstab));
                spellBook.Add(new Spells(Spells.Rogue.Eviscerate));
                spellBook.Add(new Spells(Spells.Rogue.ShadowDance));
                //-----------------
                health = 400;
                healthCap = health;
                mana = 500;
                manaCap = mana;
                this.weapon.ItemValueGetSet += 100;
            }
            //Setting equipment--------------------------------------------------------------------------------------
            this.head = new Item(Item.KindOfItem.Armory, Item.KindOfArmory.Head, this.characterClass);
            this.shoulders = new Item(Item.KindOfItem.Armory, Item.KindOfArmory.Sholders, this.characterClass);
            this.chest = new Item(Item.KindOfItem.Armory, Item.KindOfArmory.Hands, this.characterClass);
            this.hands = new Item(Item.KindOfItem.Armory, Item.KindOfArmory.Hands, this.characterClass);
            this.legs = new Item(Item.KindOfItem.Armory, Item.KindOfArmory.Legs, this.characterClass);
            this.feet = new Item(Item.KindOfItem.Armory, Item.KindOfArmory.Feet, this.characterClass);
            this.armor += armorValueFromEquipment();
            this.armorCap = armor;
            
        }
        //Create MOB--------------------------
        public Character()
        {
            this.userName = "MOB";
            this.health = 100;
            this.healthCap = 100;
            this.armor = 40;
        }
        //Create Boss-------------------------
        public Character(
            string newUserName,
            int newHealth,
            int newDamage,
            int newArmorCap)
        {
            this.userName = newUserName;
            this.health = newHealth;
            this.healthCap = newHealth;
            this.damage = newDamage;
            this.armorCap = newArmorCap;
            this.armor = armorCap;

        }

        public void mobAttack(Character attacker, Character attacked, int damage, int stageNumber = 0, int replayGame = 0)
        {
            Random rnd = new Random();
            int randomDamage = rnd.Next(damage - 10, damage);
            attacked.health -= randomDamage + valueByLevel(attacker.level);
            attacked.health += attacked.armor;
            if (attacked.health > attacked.healthCap) 
            { 
                attacked.health = attacked.healthCap; 
            }
            attacked.armor -= 70;
            checkAlive(attacker, attacked, stageNumber, replayGame);
        }
        public int armorValueFromEquipment()
        {
            armor += head.ItemValueGetSet 
                     + shoulders.ItemValueGetSet 
                     + hands.ItemValueGetSet 
                     + chest.ItemValueGetSet 
                     + legs.ItemValueGetSet 
                     + feet.ItemValueGetSet;
            return armor;              
        }
        public int valueByLevel(int level)
        {
            int addDamage = 10;
            addDamage *= level;
            return addDamage;
        }
        public void checkAlive(Character attacker, Character attacked, int stageNumber = 0, int replayGame = 0)
        {
            if (attacked.health <= 0)
            {
                Console.WriteLine("\n{0} was killed by, {1}!", attacked.userName, attacker.userName);
                gold += 100;
                Console.ReadKey();
                //------------------------------
                if (attacked.checkHero == true)
                {
                    Console.WriteLine("\nEND game at ----> |STAGE: {0} - REPLAY: {1}|", stageNumber, replayGame);
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                else if (attacker.checkHero == true)
                {
                    attacker.checkLevelUp(attacker);
                }
            }
        }
        public void checkLevelUp(Character hero)
        {
            experience += 10 * valueByLevel(level);
            if (hero.experience >= hero.experienceCap)
            {
                level++;
                experienceCap *= 2;
                healthCap += 200;
                health = healthCap;
                manaCap += 100;
                mana = manaCap;
                armorCap += 40;
                armor = armorCap;

                weapon.ItemLevelGetSet++;
                weapon.ItemValueGetSet += 10;
                head.ItemLevelGetSet++;
                head.ItemValueGetSet += 5;
                shoulders.ItemLevelGetSet++;
                shoulders.ItemValueGetSet += 5;
                hands.ItemLevelGetSet++;
                hands.ItemValueGetSet += 5;
                chest.ItemLevelGetSet++;
                chest.ItemValueGetSet += 5;
                legs.ItemLevelGetSet++;
                legs.ItemValueGetSet += 5;
                feet.ItemLevelGetSet++;
                feet.ItemValueGetSet += 5;
                itemLevel += weapon.ItemLevelGetSet 
                             + head.ItemLevelGetSet 
                             + shoulders.ItemLevelGetSet 
                             + hands.ItemLevelGetSet 
                             + chest.ItemLevelGetSet 
                             + legs.ItemLevelGetSet 
                             + feet.ItemLevelGetSet;
                Console.WriteLine("\n{0} has leveled up at level {1} and his/her stats get increased!", hero.userName, level);
                Console.WriteLine();
            }
        }
        public void castSpell(Character attacker, Character attacked, Spells spell)
        {
            if (attacker.characterClass.CharacterClass.Equals(spell.SpellClass.CharacterClass))
            {
                if (mana >= spell.ManaGet)
                {
                    mana -= spell.ManaGet;
                    Random rnd = new Random();
                    int randomValue = rnd.Next(spell.SpellValue - 20, spell.SpellValue);
                    if (spell.KindOfSpellGet == Spells.KindOfSpell.Damage)
                    {
                        attacked.health -= randomValue + valueByLevel(attacker.level) + weapon.ItemValueGetSet;
                        attacked.health += attacked.armor;
                        if (health > healthCap) { health = healthCap; }
                        attacked.armor -= 5;
                        checkAlive(attacker, attacked);
                    }

                    else if (spell.KindOfSpellGet == Spells.KindOfSpell.Heal)
                    {
                        attacker.health += randomValue + valueByLevel(attacker.level) + weapon.ItemValueGetSet;
                        if (attacker.health > attacker.healthCap)
                        {
                            int overHealth = 0;
                            overHealth = attacker.health - attacker.healthCap;
                            attacker.health -= overHealth;
                        }
                    }

                    else if (spell.KindOfSpellGet == Spells.KindOfSpell.LifeSteal)
                    {
                        attacked.health -= (randomValue - attacked.armor) + valueByLevel(attacker.level) + weapon.ItemValueGetSet;
                        attacked.armor -= 5;
                        attacker.health += randomValue + valueByLevel(attacker.level) + weapon.ItemValueGetSet;
                        if (attacker.health > attacker.healthCap)
                        {
                            int overHealth = 0;
                            overHealth = attacker.health - attacker.healthCap;
                            attacker.health -= overHealth;
                        }
                    }

                    else if (spell.KindOfSpellGet == Spells.KindOfSpell.ArmorGain)
                    {
                        attacker.armor += randomValue + valueByLevel(attacker.level);
                    }

                    if (mana <= 100)
                    {
                        Console.WriteLine("\nLow mana");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("\nInsufficent mana");
                    Console.ReadKey();
                }
                if (mana < 0)
                {
                    mana = 0;
                }
            }
        }
        public void castCombo(Character attacker, Character attacked, Spells spell1, Spells spell2)
        {
            castSpell(attacker, attacked, spell1);
            castSpell(attacker, attacked, spell2);
            mana -= 50;
        }
        public void addUltimate()
        {
            if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.Warrior)))
            {
                spellBook.Add(new Spells(Spells.Warrior.GladiatorRage));
            }
        }
        private List<Item> inventory = new List<Item>();
        public List<Item> InventoryGet
        {
            get
            {
                return this.inventory;
            }
        }
        private List<Spells> spellBook  = new List<Spells>();
        public void buyItem(int command, int power)
        {
            //Buy weapon--------------------------------------------------------
            if (command == 1)
            {
                if (level >= 5)
                {
                    if (gold >= 450)
                    {
                        if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.Warrior).CharacterClass))
                        {
                            inventory.Add(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe, "Wrathfull Axe"));
                            inventory[searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe, "Wrathfull Axe"))].ItemValueGetSet += (200 * power);
                        }
                        else if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.Shaman).CharacterClass))
                        {
                            inventory.Add(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.FistWeapon, "Wrathfull Fists"));
                            inventory[searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe, "Wrathfull Axe"))].ItemValueGetSet += (200 * power);
                        }
                        else if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.Rouge).CharacterClass))
                        {
                            inventory.Add(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Daggers, "Wrathfull Daggers"));
                            inventory[searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe, "Wrathfull Axe"))].ItemValueGetSet += (200 * power);
                        }
                        else if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.Paladin).CharacterClass))
                        {
                            inventory.Add(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Hammer, "Wrathfull Hammer"));
                            inventory[searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe, "Wrathfull Axe"))].ItemValueGetSet += (200 * power);
                        }
                        else if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.Monk).CharacterClass))
                        {
                            inventory.Add(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Polearm, "Wrathfull Polearm"));
                            inventory[searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe, "Wrathfull Axe"))].ItemValueGetSet += (200 * power);
                        }
                        else if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.Hunter).CharacterClass))
                        {
                            inventory.Add(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Bow, "Wrathfull Bow"));
                            inventory[searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe, "Wrathfull Axe"))].ItemValueGetSet += (200 * power);
                        }
                        else if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.DemonHunter).CharacterClass))
                        {
                            inventory.Add(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.TwinBlades, "Wrathfull Twinblades"));
                            inventory[searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe, "Wrathfull Axe"))].ItemValueGetSet += (200 * power);
                        }
                        else if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.DeathKnight).CharacterClass))
                        {
                            inventory.Add(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Sword, "Wrathfull Sword"));
                            inventory[searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe, "Wrathfull Axe"))].ItemValueGetSet += (200 * power);
                        }

                        else if (characterClass.CharacterClass.Equals(new Classes(Classes.Class.Druid).CharacterClass)
                                               || characterClass.CharacterClass.Equals(new Classes(Classes.Class.Mage).CharacterClass)
                                               || characterClass.CharacterClass.Equals(new Classes(Classes.Class.Priest).CharacterClass)
                                               || characterClass.CharacterClass.Equals(new Classes(Classes.Class.Warlock).CharacterClass))
                        {
                            inventory.Add(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Staff, "Wrathfull Staff"));
                            inventory[searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe, "Wrathfull Axe"))].ItemValueGetSet += (200 * power);
                        }
                        gold -= 450;
                        Console.WriteLine("\nWeapon added to your inventory");
                    }
                    else { Console.WriteLine("\nInsufficent gold"); }
                }
                else { Console.WriteLine("\nYou need level 5+ to buy weapon"); }
            }

            //Buy Health potion--------------------------------------------------------------------------
            if (command == 2 && gold >= 50)
            {
                inventory.Add(new Item(Item.KindOfItem.Potion, Item.KindOfPotion.Health));
                gold -= 50;
                Console.WriteLine("\nHealth potion added to your inventory");
            }
            else if (command == 2 && gold <= 50)
            { 
                Console.WriteLine("\nInsufficent gold"); 
            }

            //Buy Mana Potion----------------------------------------------------------------------------
            if (command == 3 && gold >= 50)
            {
                inventory.Add(new Item(Item.KindOfItem.Potion, Item.KindOfPotion.Mana));
                gold -= 50;
                Console.WriteLine("\nMana potion added to your inventory");
            }
            else if (command == 3 && gold <= 50)
            { 
                Console.WriteLine("\nInsufficent gold"); 
            }
        }
        public void showInventory()
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine("\n{0}. {1}", i, inventory[i].NameGetSet);
            }
            Console.WriteLine("\nGold: {0}", gold);
        }
        public int searchItem(Item itemForSearch)
        {
            //search for potions--------------------------------
            int position = 9999;
            for (int i = 0; i < inventory.Count; i++)
            {
                if (itemForSearch.KindOfItemGet.Equals(inventory[i].KindOfItemGet) && inventory[i].KindOfItemGet.Equals(new Item(Item.KindOfItem.Potion, Item.KindOfPotion.Health).KindOfItemGet))
                {
                    if (itemForSearch.KindOfPotionGet.Equals(inventory[i].KindOfPotionGet))
                    {
                        position = i;
                        break;
                    }
                    else { continue; }
                }
                //search for weapon-----------------------------
                if (itemForSearch.KindOfItemGet.Equals(inventory[i].KindOfItemGet))
                {
                    position = i;
                    break;
                }
            }
            return position;
        }
        public int countWeapons(Item itemForSearch)
        {
            int count = 0;
            for (int i = 0; i < inventory.Count; i++)
            {
                if (itemForSearch.KindOfItemGet.Equals(inventory[i].KindOfItemGet))
                {
                    count++;
                }
            }
            return count;
        }
        public int countHealthPotions(Item itemForSearch)
        {
            int count = 0;

            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].KindOfPotionGet.Equals(new Item(Item.KindOfItem.Potion, Item.KindOfPotion.Health).KindOfPotionGet))
                {
                    count++;    
                }
                else { continue; }
            }
            return count;
        }
        public int countManaPotions(Item itemForSearch)
        {
            int count = 0;

            for (int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].KindOfPotionGet.Equals(new Item(Item.KindOfItem.Potion, Item.KindOfPotion.Mana).KindOfPotionGet))
                {
                    count++;
                }
                else { continue; }
            }
            return count;
        }
        public void useItem(int command)
        {
            if (command == 1)
            {   
                //Changing items--------------------------
                if (searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe)) == 9999
                    && searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Daggers)) == 9999
                    && searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.FistWeapon)) == 9999
                    && searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Hammer)) == 9999
                    && searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Polearm)) == 9999
                    && searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Staff)) == 9999
                    && searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Sword)) == 9999
                    && searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.TwinBlades)) == 9999
                    && searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Bow)) == 9999)
                {
                    Console.WriteLine("\nNo weapons in the inventory");
                }
                else
                {
                    string name = weapon.NameGetSet;
                    weapon.NameGetSet = inventory[searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe))].NameGetSet;
                    inventory[searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe))].NameGetSet = name;

                    weapon.ItemValueGetSet = weapon.ItemValueGetSet ^ inventory[searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe))].ItemValueGetSet;
                    inventory[searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe))].ItemValueGetSet = weapon.ItemValueGetSet ^ inventory[searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe))].ItemValueGetSet;
                    weapon.ItemValueGetSet = weapon.ItemValueGetSet ^ inventory[searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe))].ItemValueGetSet;

                    weapon.ItemLevelGetSet = weapon.ItemLevelGetSet ^ inventory[searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe))].ItemLevelGetSet;
                    inventory[searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe))].ItemLevelGetSet = weapon.ItemLevelGetSet ^ inventory[searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe))].ItemLevelGetSet;
                    weapon.ItemLevelGetSet = weapon.ItemLevelGetSet ^ inventory[searchItem(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe))].ItemLevelGetSet;
                }
            }

            if (command == 2)
            {
                if (searchItem(new Item(Item.KindOfItem.Potion, Item.KindOfPotion.Health)) == 9999)
                {
                    Console.WriteLine("\nNo health potions!");
                }
                else
                {
                    health += inventory[searchItem(new Item(Item.KindOfItem.Potion, Item.KindOfPotion.Health))].ItemValueGetSet;
                    inventory.RemoveAt(searchItem(new Item(Item.KindOfItem.Potion, Item.KindOfPotion.Health)));
                    if (health > healthCap)
                    {
                        health = healthCap;
                    }
                }
            }

            if (command == 3)
            {
                if (searchItem(new Item(Item.KindOfItem.Potion, Item.KindOfPotion.Mana)) == 9999)
                {
                    Console.WriteLine("\nNo mana potions!");
                }
                else
                {
                    mana += inventory[searchItem(new Item(Item.KindOfItem.Potion, Item.KindOfPotion.Mana))].ItemValueGetSet;
                    inventory.RemoveAt(searchItem(new Item(Item.KindOfItem.Potion, Item.KindOfPotion.Mana)));
                    if (mana > manaCap)
                    {
                        mana = manaCap;
                    }
                }
            }
        }
        public Character becomeHero(Character newHero)
        {
            Character hero = 
                new Character("",
                new Hair(Hair.HairColor.Black, Hair.HairStyle.Medium),
                new Eyes(Eyes.EyesColor.Red, Eyes.EyesOpen.Normal),
                new BodyAndSkin(BodyAndSkin.SkinColor.Red, BodyAndSkin.BodyType.Muscular),
                new FactionRaceGender(FactionRaceGender.HordeRaces.Orc, FactionRaceGender.Gender.Male),
                new Classes(Classes.Class.Warrior, new FactionRaceGender(FactionRaceGender.HordeRaces.Orc)));
            //Building your hero----------------------------------------------------------
            //Cosmetics-------------------------------------
            hero.userName = newHero.userName;
            //-----
            hero.hair.HairColorGetSet = newHero.hair.HairColorGetSet;
            hero.hair.HaorStyleGetSet = newHero.hair.HaorStyleGetSet;
            //-----
            hero.eyes.EyesColorGetSet = newHero.eyes.EyesColorGetSet;
            hero.eyes.EyesOpenGetSet = newHero.eyes.EyesOpenGetSet;
            //-----
            hero.bodyAndSkin.BodyTypeGetSet = newHero.bodyAndSkin.BodyTypeGetSet;
            hero.bodyAndSkin.SkinColorGetSet = newHero.bodyAndSkin.SkinColorGetSet;
            //-----
            hero.factionRaceGender.AllianceRacesGetSet = newHero.factionRaceGender.AllianceRacesGetSet;
            hero.factionRaceGender.HordeRacesGetSet = newHero.factionRaceGender.HordeRacesGetSet;
            hero.factionRaceGender.FactionGetSet = newHero.factionRaceGender.FactionGetSet;
            hero.factionRaceGender.GenderGetSet = newHero.factionRaceGender.GenderGetSet;
            //-----
            hero.characterClass.CharacterClass = newHero.characterClass.CharacterClass;

            //Stats--------------------------------------------
            hero.health = newHero.health;
            hero.healthCap = newHero.healthCap;
            hero.mana = newHero.mana;
            hero.manaCap = newHero.manaCap;
            hero.armor = newHero.armor;
            hero.armorCap = newHero.armorCap;

            //Equipment----------------------------------------
            hero.weapon.NameGetSet = newHero.weapon.NameGetSet;
            hero.weapon.KindOfWeaponGetSet = newHero.weapon.KindOfWeaponGetSet;
            hero.weapon.ItemValueGetSet = newHero.weapon.ItemValueGetSet;
            //-----
            hero.head.ItemValueGetSet = newHero.head.ItemValueGetSet;
            hero.head.ArmorMaterialGetSet = newHero.head.ArmorMaterialGetSet;
            //-----
            hero.shoulders.ItemValueGetSet = newHero.shoulders.ItemValueGetSet;
            hero.shoulders.ArmorMaterialGetSet = newHero.shoulders.ArmorMaterialGetSet;
            //-----
            hero.hands.ItemLevelGetSet = newHero.hands.ItemLevelGetSet;
            hero.hands.ArmorMaterialGetSet = newHero.hands.ArmorMaterialGetSet;
            //-----
            hero.chest.ItemLevelGetSet = newHero.chest.ItemLevelGetSet;
            hero.chest.ArmorMaterialGetSet = newHero.chest.ArmorMaterialGetSet;
            //-----
            hero.legs.ItemLevelGetSet = newHero.legs.ItemLevelGetSet;
            hero.legs.ArmorMaterialGetSet = newHero.legs.ArmorMaterialGetSet;
            //-----
            hero.feet.ItemLevelGetSet = newHero.feet.ItemLevelGetSet;
            hero.feet.ArmorMaterialGetSet = newHero.feet.ArmorMaterialGetSet;

            hero.spellBook = newHero.spellBook;
            return hero;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n");
            sb.AppendFormat("{0}\n", userName);
            sb.AppendFormat("___________________\n");
            sb.AppendFormat("Cosmetics-------\n");
            sb.AppendFormat("Hair: {0}-{1}\n", hair.HairColorGetSet, hair.HaorStyleGetSet);
            sb.AppendFormat("Eyes: {0}\n", eyes.EyesColorGetSet);
            sb.AppendFormat("Skin color: {0} / Body type: {1}\n", bodyAndSkin.SkinColorGetSet, bodyAndSkin.BodyTypeGetSet);
            sb.AppendFormat("Faction: {0}\n", factionRaceGender.FactionGetSet);
            if (factionRaceGender.AllianceRacesGetSet.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.x).AllianceRacesGetSet))
            {
                sb.AppendFormat("Race: {0}\n", factionRaceGender.HordeRacesGetSet);
            }
            else if (factionRaceGender.HordeRacesGetSet.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.x).HordeRacesGetSet))
            {
                sb.AppendFormat("Race: {0}\n", factionRaceGender.AllianceRacesGetSet);
            }
            sb.AppendFormat("Gender: {0}\n", factionRaceGender.GenderGetSet);
            sb.AppendFormat("Stats-----------\n");
            sb.AppendFormat("Level: {0}({1})\n", level, characterClass.CharacterClass);
            sb.AppendFormat("Health: {0}/{1}\n", health, healthCap);
            sb.AppendFormat("Mana: {0}/{1}\n", mana, manaCap);
            sb.AppendFormat("Item level: {0}\n", itemLevel);
            sb.AppendFormat("Experience: {0}/{1}\n", experience, experienceCap);
            sb.AppendFormat("Equipment-------\n");
            sb.AppendFormat("Weapon Damage: {0}({1}) -> Rarity: {2}\n", weapon.ItemValueGetSet, weapon.KindOfWeaponGetSet, weapon.NameGetSet);
            sb.AppendFormat("Armor: {0}/{1}({2})\n", armor, armorCap, head.ArmorMaterialGetSet);
            return sb.ToString();
        }
        public StringBuilder showHeroFightStats()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n{0}\n", userName);
            sb.AppendFormat("-----------\n");
            sb.AppendFormat("Health: {0}/{1}\n", health, healthCap);
            sb.AppendFormat("Mana: {0}/{1}\n", mana, manaCap);
            sb.AppendFormat("Armor: {0}/{1}\n", armor,armorCap);

            return sb;
        }
        public StringBuilder showMonsterFightStats()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n{0}\n", userName);
            sb.AppendFormat("-----------\n");
            sb.AppendFormat("Health: {0}/{1}\n", health, healthCap);
            sb.AppendFormat("Damage: {0}\n", damage);
            sb.AppendFormat("Armor: {0}/{1}\n", armor, armorCap);

            return sb;
        }
        public void levelUpStage()
        {
            damage += 150;
            healthCap += 1500;
            health = healthCap;
            armorCap += 150;
            armor = armorCap;
        }
    }
}
