using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowAgain
{
    class Classes
    {
        private Class characterClass;
        public Class CharacterClass
        {
            get
            {
                return this.characterClass;
            }
            set
            {
                this.characterClass = value;
            }
        }
        public enum Class
        {
            Warrior,
            Paladin,
            Hunter,
            Rouge,
            Priest,
            DeathKnight,
            Shaman,
            Mage,
            Warlock,
            Monk,
            Druid,
            DemonHunter
        }
        public Classes(
            Class newCharacterClass)
        {
            this.characterClass = newCharacterClass;
        }
        public Classes(
            Class newCharacterClass,
            FactionRaceGender newRace)
        {
            if (newCharacterClass.Equals(new Classes(Classes.Class.Warrior).CharacterClass) && (newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Draenei).ARace) 
                                                                              || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Dwarf).ARace) 
                                                                              || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Gnome).ARace) 
                                                                              || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Human).ARace) 
                                                                              || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.NightElf).ARace) 
                                                                              || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Pandaren).ARace) 
                                                                              || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Worgen).ARace) 
                                                                              || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.BloodElf).HRace) 
                                                                              || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Goblin).HRace) 
                                                                              || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Orc).HRace) 
                                                                              || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Pandaren).HRace) 
                                                                              || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Tauren).HRace) 
                                                                              || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Troll).HRace) 
                                                                              || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Undead).HRace) ))                                                   
            {
                this.characterClass = newCharacterClass;
            }

            else if (newCharacterClass.Equals(new Classes(Classes.Class.Warlock).CharacterClass) && (newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Dwarf).ARace) 
                                                                                   || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Gnome).ARace) 
                                                                                   || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Human).ARace) 
                                                                                   || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Worgen).ARace) 
                                                                                   || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.BloodElf).HRace) 
                                                                                   || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Goblin).HRace) 
                                                                                   || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Orc).HRace) 
                                                                                   || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Troll).HRace) 
                                                                                   || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Undead).HRace)))
            {
                this.characterClass = newCharacterClass;
            }

            else if (newCharacterClass.Equals(new Classes(Classes.Class.Shaman).CharacterClass) && (newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Draenei).ARace)
                                                                                  || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Dwarf).ARace)
                                                                                  || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Pandaren).ARace)
                                                                                  || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Goblin).HRace)
                                                                                  || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Orc).HRace)
                                                                                  || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Pandaren).HRace)
                                                                                  || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Troll).HRace)))
            {
                this.characterClass = newCharacterClass;
            }

            else if (newCharacterClass.Equals(new Classes(Classes.Class.Rouge).CharacterClass) && (newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Dwarf).ARace)
                                                                                 || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Gnome).ARace)
                                                                                 || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Human).ARace)
                                                                                 || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.NightElf).ARace)
                                                                                 || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Pandaren).ARace)
                                                                                 || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Worgen).ARace)
                                                                                 || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.BloodElf).HRace)
                                                                                 || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Goblin).HRace)
                                                                                 || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Orc).HRace)
                                                                                 || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Pandaren).HRace)
                                                                                 || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Troll).HRace)
                                                                                 || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Undead).HRace)))
            {
                this.characterClass = newCharacterClass;
            }

            else if (newCharacterClass.Equals(new Classes(Classes.Class.Priest).CharacterClass) && (newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Draenei).ARace)
                                                                                  || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Dwarf).ARace)
                                                                                  || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Gnome).ARace)
                                                                                  || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Human).ARace)
                                                                                  || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.NightElf).ARace)
                                                                                  || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Pandaren).ARace)
                                                                                  || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Worgen).ARace)
                                                                                  || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.BloodElf).HRace)
                                                                                  || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Goblin).HRace)
                                                                                  || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Pandaren).HRace)
                                                                                  || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Tauren).HRace)
                                                                                  || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Troll).HRace)
                                                                                  || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Undead).HRace)))
            {
                this.characterClass = newCharacterClass;
            }

            else if (newCharacterClass.Equals(new Classes(Classes.Class.Paladin).CharacterClass) && (newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Draenei).ARace)
                                                                                   || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Dwarf).ARace)
                                                                                   || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Human).ARace)
                                                                                   || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.BloodElf).HRace)
                                                                                   || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Tauren).HRace)))
            {
                this.characterClass = newCharacterClass;
            }

            else if (newCharacterClass.Equals(new Classes(Classes.Class.Monk).CharacterClass) && (newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Draenei).ARace)
                                                                                || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Dwarf).ARace)
                                                                                || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Gnome).ARace)
                                                                                || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Human).ARace)
                                                                                || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.NightElf).ARace)
                                                                                || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Pandaren).ARace)
                                                                                || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.BloodElf).HRace)
                                                                                || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Orc).HRace)
                                                                                || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Pandaren).HRace)
                                                                                || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Tauren).HRace)
                                                                                || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Troll).HRace)
                                                                                || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Undead).HRace)))
            {
                this.characterClass = newCharacterClass;
            }

            else if (newCharacterClass.Equals(new Classes(Classes.Class.Mage).CharacterClass) && (newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Draenei).ARace)
                                                                                || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Dwarf).ARace)
                                                                                || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Gnome).ARace)
                                                                                || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Human).ARace)
                                                                                || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.NightElf).ARace)
                                                                                || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Pandaren).ARace)
                                                                                || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Worgen).ARace)
                                                                                || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.BloodElf).HRace)
                                                                                || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Goblin).HRace)
                                                                                || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Orc).HRace)
                                                                                || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Pandaren).HRace)
                                                                                || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Troll).HRace)
                                                                                || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Undead).HRace)))
            {
                this.characterClass = newCharacterClass;
            }

            else if (newCharacterClass.Equals(new Classes(Classes.Class.Hunter).CharacterClass) && (newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Draenei).ARace)
                                                                                  || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Dwarf).ARace)
                                                                                  || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Gnome).ARace)
                                                                                  || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Human).ARace)
                                                                                  || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.NightElf).ARace)
                                                                                  || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Pandaren).ARace)
                                                                                  || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Worgen).ARace)
                                                                                  || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.BloodElf).HRace)
                                                                                  || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Goblin).HRace)
                                                                                  || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Orc).HRace)
                                                                                  || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Pandaren).HRace)
                                                                                  || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Tauren).HRace)
                                                                                  || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Troll).HRace)
                                                                                  || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Undead).HRace)))
            {
                this.characterClass = newCharacterClass;
            }

            else if (newCharacterClass.Equals(new Classes(Classes.Class.Druid).CharacterClass) && (newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.NightElf).ARace)
                                                                                 || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Worgen).ARace)
                                                                                 || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Tauren).HRace)
                                                                                 || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Troll).HRace)))
            {
                this.characterClass = newCharacterClass;
            }

            else if (newCharacterClass.Equals(new Classes(Classes.Class.DemonHunter).CharacterClass) && (newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.NightElf).ARace)
                                                                                       || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.BloodElf).HRace)))
            {
                this.characterClass = newCharacterClass;
            }

            else if (newCharacterClass.Equals(new Classes(Classes.Class.DeathKnight).CharacterClass) && (newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Draenei).ARace)
                                                                                       || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Dwarf).ARace)
                                                                                       || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Gnome).ARace)
                                                                                       || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Human).ARace)
                                                                                       || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.NightElf).ARace)
                                                                                       || newRace.ARace.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Worgen).ARace)
                                                                                       || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.BloodElf).HRace)
                                                                                       || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Goblin).HRace)
                                                                                       || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Orc).HRace)
                                                                                       || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Tauren).HRace)
                                                                                       || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Troll).HRace)
                                                                                       || newRace.HRace.Equals(new FactionRaceGender(FactionRaceGender.HordeRaces.Undead).HRace)))
            {
                this.characterClass = newCharacterClass;
            }
        }
    }
}
