using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class BloodLust : Spell, ISpellCastTo, IWarrior
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

        public BloodLust(
            double value, 
            double powerCost,
            int levelRequired,
            int coolDownDuration)
            : base(
                  "Blood Lust",
                  value, 
                  powerCost,
                  levelRequired, 
                  coolDownDuration)
        {
        }

        public override void CastTo(ICharacter attacker, ICharacter defender)
        {
            try
            {
                if (CheckMultiCast.CheckUsabilityCastTo(attacker, this, defender) == true)
                {
                    base.CastTo(attacker, defender);
                    attacker.Power.PowerGenerate(this);
                    defender.HealthCurr -= base.Value;
                }
            }
            catch (InvalidOperationException) { }
        }
    }
}
