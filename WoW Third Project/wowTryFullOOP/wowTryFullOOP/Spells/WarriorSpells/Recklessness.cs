using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace wowTryFullOOP
{
    public class Recklessness : Spell, ISpellCast, IWarrior
    {
        private bool isWarrior;

        public bool IsWarrior
        {
            get
            {
                return this.isWarrior;
            }
            private set
            {
                this.isWarrior = true;
            }
        }

        public Recklessness(
            double value,
            double powerCost, 
            int levelRequired,
            int coolDownDuration) 
            : base(
                  "Recklessness",
                  value,
                  powerCost, 
                  levelRequired,
                  coolDownDuration)
        {

        }

        public override void Cast(ICharacter character)
        {
            try
            {
                if (CheckMultiCast.CheckUsabilityCast(character, this) == true)
                {
                    base.spellCD = new SpellCoolDown(base.coolDownDuration);
                    character.Power.PowerGenerate(this);
                    character.HealthCurr += base.Value;

                    if(character.HealthCurr > character.HealthCap)
                    {
                        character.HealthCurr = character.HealthCap;
                    }
                }
            }
            catch (InvalidOperationException) { }
        }
    }
}
