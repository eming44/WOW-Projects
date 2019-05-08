using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public abstract class Spell : ISpell
    {
        private string name;
        private double value;
        private double powerCost;
        private int levelRequired;

        private int ticks;
        protected int coolDownDuration;
        protected SpellCoolDown spellCD;

        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public double Value
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
        public double PowerCost
        {
            get
            {
                return this.powerCost;
            }
            set
            {
                this.powerCost = value;
            }
        }
        public int LevelRequired
        {
            get
            {
                return this.levelRequired;
            }
            set
            {
                this.levelRequired = value;
            }

        }

        public int Ticks
        {
            get
            {
                return this.ticks;
            }
            set
            {
                this.ticks = value;
            }
        }
        public int Duration
        {
            get
            {
                return this.coolDownDuration;
            }
            set
            {
                this.coolDownDuration = value;
            }
        }

        public Spell(
            string name,
            double value, 
            double powerCost,
            int levelRequired,
            int coolDownDuration)
        {
            this.name = name;
            this.value = value;
            this.powerCost = powerCost;
            this.levelRequired = levelRequired;
            this.ticks = -1;
            this.coolDownDuration = coolDownDuration;
        }

        public virtual void CastTo(ICharacter attacker, ICharacter defender)
        {
            if (Check.LevelIsHigherOrEqual(attacker, LevelRequired) == true)
            {

            }
            else
            {
                throw new OperationCanceledException();
            }
        }
        public virtual void Cast(ICharacter character)
        {
            if (Check.LevelIsHigherOrEqual(character, LevelRequired) == true)
            {

            }
            else
            {
                throw new OperationCanceledException();
            }
        }
    }
}
