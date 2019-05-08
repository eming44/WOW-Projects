using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class MortalStrike : Spell, ISpellCastTo, IWarrior
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

        public MortalStrike(
            double value,
            double powerCost, 
            int levelRequired,
            int coolDownDuration)
            : base(
                  "Mortal strike",
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
                if (CheckMultiCast.CheckUsabilityCastTo(attacker, this, defender))
                {
                    base.CastTo(attacker, defender);
                    attacker.Power.PowerConsume(this);
                    defender.HealthCurr -= base.Value;
                }
            }
            catch (InvalidOperationException) { }
        }
    }
}
