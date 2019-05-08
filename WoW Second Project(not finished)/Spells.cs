using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Spells
    {
        private string spellName;
        private Classes spellClass;
        private int spellValue;
        private int mana;
        private KindOfSpell kindOfSpell;
        private Warrior warriorSpells;
        private Mage mageSpells;
        private Priest priestSpells;
        private DeathKnight deathKnightSpells;
        private Paladin paladinSpells;
        private DemonHunter demonHunterSpells;
        private Hunter hunterSpells;
        private Warlock warlockSpells;
        private Druid druidSpells;
        private Shaman shamanSpells;
        private Monk monkSpells;
        private Rogue rogueSpells;
        public int ManaGet
        {
            get
            {
                return this.mana;
            }
        }
        public string SpellNameGet
        {
            get
            {
                return this.spellName;
            }
        }
        public int SpellValue
        {
            get
            {
                return this.spellValue;
            }
        }
        public Classes SpellClass
        {
            get
            {
                return this.spellClass;
            }
        }
        public KindOfSpell KindOfSpellGet
        {
            get
            {
                return this.kindOfSpell;
            }
        }
        public enum KindOfSpell
        {
            Damage,
            Heal,
            LifeSteal,
            ArmorGain
        }
        public enum Warrior
        {
            HeroicStrike,
            Execute,
            GladiatorRage
        }
        public enum Mage
        {
            FireBall,
            PyroBlast,
            LivingBomb
        }
        public enum Priest
        {
            Heal,
            Smite,
            MindControl
        }
        public enum DeathKnight
        {
            DeathStrike,
            Lifesteal,
            ArmyOfTheDead
        }
        public enum Paladin
        {
            DivineShield,
            Judgment,
            AvengingWrath
        }
        public enum DemonHunter
        {
            DoubleSlash,
            DemonSkin,
            DemonicInfusion
        }
        public enum Hunter
        {
            SteadyShot,
            FireTrap,
            ChimeraShot

        }
        public enum Warlock
        {
            ChaosBolt,
            DrainLife,
            SacrificeDemon
        }
        public enum Druid
        {
            Swipe,
            Regrowth,
            StarFire
        }
        public enum Shaman
        {
            LavaBurst,
            LightningBolt,
            Vulcano
        }
        public enum Monk
        {
            BlackoutKick,
            FlyingSerpentKick,
            Meditaion
        }
        public enum Rogue
        {
            Backstab,
            Eviscerate,
            ShadowDance
        }
        public Spells(Mage newMageSpells)
        {
            this.mageSpells = newMageSpells;

            if (mageSpells.Equals(Mage.FireBall))
            {
                this.spellName = "Fire ball";
                this.spellValue = 160;
                this.spellClass = new Classes(Classes.Class.Mage);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 30;
            }
            if (mageSpells.Equals(Mage.PyroBlast))
            {
                this.spellName = "Pyro blast";
                this.spellValue = 220;
                this.spellClass = new Classes(Classes.Class.Mage);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 50;
            }
            if (mageSpells.Equals(Mage.LivingBomb))
            {
                this.spellName = "Living bomb";
                this.spellValue = 520;
                this.spellClass = new Classes(Classes.Class.Mage);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 80;
            }
        }
        public Spells(Warrior newWarriorSpells)
        {
            this.warriorSpells = newWarriorSpells;

            if (warriorSpells.Equals(Warrior.HeroicStrike))
            {
                this.spellName = "Heroic strike";
                this.spellValue = 150;
                this.spellClass = new Classes(Classes.Class.Warrior);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 30;
            }
            if (warriorSpells.Equals(Warrior.Execute))
            {
                this.spellName = "Execute";
                this.spellValue = 250;
                this.spellClass = new Classes(Classes.Class.Warrior);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 50;
            }
            if (warriorSpells.Equals(Warrior.GladiatorRage))
            {
                this.spellName = "Gladiator's rage";
                this.spellValue = 500;
                this.spellClass = new Classes(Classes.Class.Warrior);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 80;
            }
        }
        public Spells(Priest newPriestSpells)
        {
            this.priestSpells = newPriestSpells;

            if (priestSpells.Equals(Priest.Heal))
            {
                this.spellName = "Heal";
                this.spellValue = 100;
                this.spellClass = new Classes(Classes.Class.Priest);
                this.kindOfSpell = KindOfSpell.Heal;
                this.mana = 30;
            }
            if (priestSpells.Equals(Priest.Smite))
            {
                this.spellName = "Smite";
                this.spellValue = 245;
                this.spellClass = new Classes(Classes.Class.Priest);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 50;
            }
            if (priestSpells.Equals(Priest.MindControl))
            {
                this.spellName = "Mind control";
                this.spellValue = 490;
                this.spellClass = new Classes(Classes.Class.Priest);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 80;
            }
        }
        public Spells(DeathKnight newDeathKnightSpells)
        {
            this.deathKnightSpells = newDeathKnightSpells;

            if (deathKnightSpells.Equals(DeathKnight.DeathStrike))
            {
                this.spellName = "Death strike";
                this.spellValue = 120;
                this.spellClass = new Classes(Classes.Class.DeathKnight);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 30;
            }
            if (deathKnightSpells.Equals(DeathKnight.Lifesteal))
            {
                this.spellName = "Life steal";
                this.spellValue = 120;
                this.spellClass = new Classes(Classes.Class.DeathKnight);
                this.kindOfSpell = KindOfSpell.LifeSteal;
                this.mana = 50;
            }
            if (deathKnightSpells.Equals(DeathKnight.ArmyOfTheDead))
            {
                this.spellName = "Army of the dead";
                this.spellValue = 485;
                this.spellClass = new Classes(Classes.Class.DeathKnight);
                this.kindOfSpell = KindOfSpell.LifeSteal;
                this.mana = 80;
            }
        }
        public Spells(Paladin newPaladinSpells)
        {
            this.paladinSpells = newPaladinSpells;

            if (paladinSpells.Equals(Paladin.DivineShield))
            {
                this.spellName = "Divine shield";
                this.spellValue = 100;
                this.spellClass = new Classes(Classes.Class.Paladin);
                this.kindOfSpell = KindOfSpell.ArmorGain;
                this.mana = 50;
            }
            if (paladinSpells.Equals(Paladin.Judgment))
            {
                this.spellName = "Judgment";
                this.spellValue = 125;
                this.spellClass = new Classes(Classes.Class.Paladin);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 30;
            }
            if (paladinSpells.Equals(Paladin.AvengingWrath))
            {
                this.spellName = "Avenging wrath";
                this.spellValue = 515;
                this.spellClass = new Classes(Classes.Class.Paladin);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 80;
            }
        }
        public Spells(DemonHunter newDemonHunterSpells)
        {
            this.demonHunterSpells = newDemonHunterSpells;

            if (demonHunterSpells.Equals(DemonHunter.DoubleSlash))
            {
                this.spellName = "Double slash";
                this.spellValue = 200;
                this.spellClass = new Classes(Classes.Class.DemonHunter);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 30;
            }

            if (demonHunterSpells.Equals(DemonHunter.DemonSkin))
            {
                this.spellName = "Demon skin";
                this.spellValue = 110;
                this.spellClass = new Classes(Classes.Class.DemonHunter);
                this.kindOfSpell = KindOfSpell.ArmorGain;
                this.mana = 50;
            }
            if (demonHunterSpells.Equals(DemonHunter.DemonicInfusion))
            {
                this.spellName = "Demonic Infusion";
                this.spellValue = 600;
                this.spellClass = new Classes(Classes.Class.DemonHunter);
                this.kindOfSpell = KindOfSpell.LifeSteal;
                this.mana = 80;
            }
        }
        public Spells(Hunter newHunterSpells)
        {
            this.hunterSpells = newHunterSpells;

            if (hunterSpells.Equals(Hunter.SteadyShot))
            {
                this.spellName = "Steady shot";
                this.spellValue = 165;
                this.spellClass = new Classes(Classes.Class.Hunter);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 30;
            }
            if (hunterSpells.Equals(Hunter.FireTrap))
            {
                this.spellName = "Fire trap";
                this.spellValue = 190;
                this.spellClass = new Classes(Classes.Class.Hunter);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 50;
            }
            if (hunterSpells.Equals(Hunter.ChimeraShot))
            {
                this.spellName = "Chimera shot";
                this.spellValue = 600;
                this.spellClass = new Classes(Classes.Class.Hunter);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 80;
            }
        }
        public Spells(Warlock newWarlockSpells)
        {
            this.warlockSpells = newWarlockSpells;

            if (warlockSpells.Equals(Warlock.ChaosBolt))
            {
                this.spellName = "Chaos bolt";
                this.spellValue = 180;
                this.spellClass = new Classes(Classes.Class.Warlock);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 30;
            }
            if (warlockSpells.Equals(Warlock.DrainLife))
            {
                this.spellName = "Drain life";
                this.spellValue = 150;
                this.spellClass = new Classes(Classes.Class.Warlock);
                this.kindOfSpell = KindOfSpell.LifeSteal;
                this.mana = 50;
            }
            if (warlockSpells.Equals(Warlock.SacrificeDemon))
            {
                this.spellName = "Sacrifice demon";
                this.spellValue = 450;
                this.spellClass = new Classes(Classes.Class.Warlock);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 80;
            }
        }
        public Spells(Druid newDruidSpells)
        {
            this.druidSpells = newDruidSpells;

            if (druidSpells.Equals(Druid.Regrowth))
            {
                this.spellName = "Regrowth";
                this.spellValue = 115;
                this.spellClass = new Classes(Classes.Class.Druid);
                this.kindOfSpell = KindOfSpell.Heal;
                this.mana = 50;
            }
            if (druidSpells.Equals(Druid.Swipe))
            {
                this.spellName = "Swipe";
                this.spellValue = 145;
                this.spellClass = new Classes(Classes.Class.Druid);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 30;
            }
            if (druidSpells.Equals(Druid.StarFire))
            {
                this.spellName = "Star fire";
                this.spellValue = 445;
                this.spellClass = new Classes(Classes.Class.Druid);
                this.kindOfSpell = KindOfSpell.ArmorGain;
                this.mana = 80;
            }
        }
        public Spells(Shaman newShamanSpells)
        {
            this.shamanSpells = newShamanSpells;

            if (shamanSpells.Equals(Shaman.LavaBurst))
            {
                this.spellName = "Lava burst";
                this.spellValue = 170;
                this.spellClass = new Classes(Classes.Class.Shaman);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 30;
            }
            if (shamanSpells.Equals(Shaman.LightningBolt))
            {
                this.spellName = "Lightning bolt";
                this.spellValue = 190;
                this.spellClass = new Classes(Classes.Class.Shaman);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 50;
            }
            if (shamanSpells.Equals(Shaman.Vulcano))
            {
                this.spellName = "Vulcano";
                this.spellValue = 505;
                this.spellClass = new Classes(Classes.Class.Shaman);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 80;
            }
        }
        public Spells(Monk newMonkSpells)
        {
            this.monkSpells = newMonkSpells;

            if (monkSpells.Equals(Monk.BlackoutKick))
            {
                this.spellName = "Blackout kick";
                this.spellValue = 130;
                this.spellClass = new Classes(Classes.Class.Monk);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 30;
            }
            if (monkSpells.Equals(Monk.FlyingSerpentKick))
            {
                this.spellName = "Flying serpent kick";
                this.spellValue = 170;
                this.spellClass = new Classes(Classes.Class.Monk);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 50;
            }
            if (monkSpells.Equals(Monk.Meditaion))
            {
                this.spellName = "Flying serpent kick";
                this.spellValue = 700;
                this.spellClass = new Classes(Classes.Class.Monk);
                this.kindOfSpell = KindOfSpell.Heal;
                this.mana = 80;
            }
        }
        public Spells(Rogue newRogueSpells)
        {
            this.rogueSpells = newRogueSpells;

            if (rogueSpells.Equals(Rogue.Backstab))
            {
                this.spellName = "Backstab";
                this.spellValue = 130;
                this.spellClass = new Classes(Classes.Class.Rouge);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 30;
            }
            if (rogueSpells.Equals(Rogue.Eviscerate))
            {
                this.spellName = "Eviscerate";
                this.spellValue = 190;
                this.spellClass = new Classes(Classes.Class.Rouge);
                this.kindOfSpell = KindOfSpell.Damage;
                this.mana = 50;
            }
            if (rogueSpells.Equals(Rogue.ShadowDance))
            {
                this.spellName = "Shadow Dance";
                this.spellValue = 520;
                this.spellClass = new Classes(Classes.Class.Rouge);
                this.kindOfSpell = KindOfSpell.LifeSteal;
                this.mana = 80;
            }
        }
    }
}
