using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowTryFullOOP
{
    public class Check
    {
        public static bool LevelIsHigherOrEqual(ICharacter character, int levelChecked)
        {
            if (character.Level >= levelChecked)
            {
                return true;
            }
            else
            {
                Console.WriteLine("You don't have the required level.");
                return false;
            }
        }
        public static bool IsAlive(ICharacter character)
        {
            if (character.IsAlive == true)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"{character.Name} is dead.");
                return false;
            }
        }
        public static bool IsOnCoolDown(ICoolDownable cd)
        {
            return cd.Ticks > 0 && cd.Ticks < cd.Duration;
            //if (cd.Ticks > 0 && cd.Ticks < cd.Duration)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
        public static bool MissChance(int missChance)
        {
            Random rnd = new Random();
            int randomChance = rnd.Next(0, 100);
            return randomChance >= 0 && randomChance <= missChance;
            //if (randomChance >= 0 && randomChance <= missChance)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
        public static bool IsPlate(IEquippable<Item> item)
        {
            return item is IPlate;
            //if (item is IPlate)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
        public static bool IsEquippableByWarrior(IEquippable<Item> item)
        {
            return item is IPlate || item is ISword || item is IAxe || item is IHammer;
            //if (item is IPlate
            //    || item is ISword
            //    || item is IAxe
            //    || item is IHammer)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
        public static bool IsEquippableByMage(IEquippable<Item> item)
        {
            //if (item is ICloth
            //    || item is IStaff)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

            return item is ICloth || item is IStaff;
        }
        public static bool IsCastableByWarrior(IHero hero, ISpell spell)
        {
            return spell is IWarrior;

            //if (spell is IWarrior)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
