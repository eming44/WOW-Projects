using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class CheckMultiCast
    {
        public static bool CheckUsabilityCastTo(ICharacter attacker, ISpell spell, ICharacter attacked)
        {
            if (Check.LevelIsHigherOrEqual(attacker, spell.LevelRequired) == true 
                && Check.IsAlive(attacker) == true 
                && Check.IsOnCoolDown(spell) == false
                && Check.MissChance(attacked.MissChance) == false)
            {
                return true;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
        public static bool CheckUsabilityCast(ICharacter attacker, ISpell spell)
        {
            if (Check.LevelIsHigherOrEqual(attacker, spell.LevelRequired) == true 
                && Check.IsAlive(attacker) == true 
                && Check.IsOnCoolDown(spell) == false)
            {
                return true;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
        public static bool CheckUsabilityAttack(ICharacter attacker, ICharacter attacked)
        {
            if (Check.IsAlive(attacker) == true
                && Check.MissChance(attacked.MissChance) == false)
            {
                return true;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
        public static bool ChechEquippability(IHero hero, IEquippable<Item> item)
        {
            return Check.IsAlive(hero) == true
                && Check.LevelIsHigherOrEqual(hero, item.LevelNeeded) == true;
        }
    }
}
