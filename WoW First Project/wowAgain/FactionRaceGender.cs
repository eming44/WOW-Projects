using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowAgain
{
    class FactionRaceGender
    {
        private Gender gender;
        private AllianceRaces aRace;
        private HordeRaces hRace;
        private Faction faction;

        public Gender GenderGetSet
        {
            get
            {
                return this.gender;
            }
            set
            {
                this.gender = value;
            }
        }
        public AllianceRaces AllianceRacesGetSet
        {
            get
            {
                return this.aRace;
            }
            set
            {
                this.aRace = value;
            }
        }
        public HordeRaces HordeRacesGetSet
        {
            get
            {
                return this.hRace;
            }
            set
            {
                this.hRace = value;
            }
        }
        public Faction FactionGetSet
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
            }
        }
        public enum Gender
        {
            Male,
            Female
        }
        public enum Faction
        {
            Alliance,
            Horde
        }
        public enum AllianceRaces
        {
            Human,
            Dwarf,
            NightElf,
            Gnome,
            Draenei,
            Worgen,
            Pandaren,
            x
        }
        public enum HordeRaces
        {
            Orc,
            Undead,
            Tauren,
            Troll,
            BloodElf,
            Goblin,
            Pandaren,
            x
        }
        public AllianceRaces ARace
        {
            get
            {
                return this.aRace;
            }
        }
        public HordeRaces HRace
        {
            get
            {
                return this.hRace;
            }
        }
        //----ALLIANCE----
        public FactionRaceGender(
            AllianceRaces newRace,
            Gender newGender)
        {
            this.aRace = newRace;
            this.gender = newGender;
            this.faction = Faction.Alliance;
            this.hRace = HordeRaces.x;
        }

        //----HORDE----
        public FactionRaceGender(
            HordeRaces newRace,
            Gender newGender)
        {
            this.hRace = newRace;
            this.gender = newGender;
            this.faction = Faction.Horde;
            this.aRace = AllianceRaces.x;
        }
        public FactionRaceGender(AllianceRaces newRace)
        {
            this.aRace = newRace;
            this.faction = Faction.Alliance;
        }
        public FactionRaceGender(HordeRaces newRace)
        {
            this.hRace = newRace;
            this.faction = Faction.Horde;
        }
    }
}
