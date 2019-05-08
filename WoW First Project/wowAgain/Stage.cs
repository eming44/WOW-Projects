using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowAgain
{
    class Stage
    {
        public Stage()
        { }
        public void askUsePotion(Character hero)
        {
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("\nDo you want to use a potion?");
                Console.WriteLine("1 -> Use health potion");
                Console.WriteLine("2 -> Use mana potion");
                Console.WriteLine("3 <--- Back");
                char commad = Console.ReadKey().KeyChar;
                Console.WriteLine();
                switch (commad)
                {
                    case '1':
                        hero.useItem(2);
                        break;

                    case '2':
                        hero.useItem(3);
                        break;

                    case '3':
                        exit = true;
                        break;
                }
            }
        }
        public void fightStage(Character hero, Character monster, int stageNumber, int replayGame)
        {
            bool completed = false;
            do
            {

                Console.Clear();
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("-----STAGE {0}--replay {1}---\n\n", stageNumber, replayGame);
                sb.AppendFormat("Boss: {0}\n", monster.UserNameGet);
                sb.AppendFormat("Damage: {0}\n", monster.DamageGet);
                sb.AppendFormat("Health: {0}\n", monster.HealthGetSet);
                sb.AppendFormat("Armor: {0}/{1}\n", monster.ArmorGetSet, monster.ArmorCapGet);
                sb.AppendFormat("-------------------\n");
                sb.AppendFormat("1. Fight monster\n");
                sb.AppendFormat("2. Open shop\n");
                sb.AppendFormat("3. Show hero stats\n");
                sb.AppendFormat("4. Open inventory\n");
                sb.AppendFormat("Use command: ");
                Console.WriteLine(sb);

                char a = Console.ReadKey().KeyChar;

                try
                {
                    while(a != '1' &&
                          a != '2' &&
                          a != '3' &&
                          a != '4')
                    {
                        throw new FormatException();
                    }
                    switch (a)
                    {
                        case '1':
                            bool exit = false;
                            while (hero.HealthGetSet > 0 && monster.HealthGetSet > 0 && exit == false)
                            {

                                Console.WriteLine(monster.showMonsterFightStats());
                                Console.WriteLine("----------------------------------------");
                                Console.WriteLine(hero.showHeroFightStats());
                                Console.WriteLine();
                                StringBuilder sb1 = new StringBuilder();
                                sb1.AppendFormat("{0}, attacks\n\n", hero.UserNameGet);

                                sb1.AppendFormat("1. Basic attack -> Damage({0}) | Mana(free)\n", hero.WeaponGet.ItemValueGetSet);
                                sb1.AppendFormat("Spell Book-----------\n");
                                sb1.AppendFormat("2. {0} -> ({1} + {2}(weapon)) {3} | Mana({4})\n", hero.SpellBookGet[0].SpellNameGet, hero.SpellBookGet[0].SpellValue, hero.WeaponGet.ItemValueGetSet, hero.SpellBookGet[0].KindOfSpellGet, hero.SpellBookGet[0].ManaGet);
                                sb1.AppendFormat("3. {0} -> ({1} + {2}(weapon)) {3} | Mana({4})\n", hero.SpellBookGet[1].SpellNameGet, hero.SpellBookGet[1].SpellValue, hero.WeaponGet.ItemValueGetSet, hero.SpellBookGet[1].KindOfSpellGet, hero.SpellBookGet[1].ManaGet);
                                sb1.AppendFormat("4. Combo (both spells)  | Mana(120)\n", hero.SpellBookGet[1].SpellNameGet, hero.SpellBookGet[1].SpellValue, hero.SpellBookGet[1].KindOfSpellGet);
                                sb1.AppendFormat("5. Ultimete(lvl-6): {0}  -> ({1} + {2}(weapon)) {3} | Mana({4})\n", hero.SpellBookGet[2].SpellNameGet, hero.SpellBookGet[2].SpellValue, hero.WeaponGet.ItemValueGetSet, hero.SpellBookGet[2].KindOfSpellGet, hero.SpellBookGet[2].ManaGet);
                                sb1.AppendFormat("---------------------\n");
                                sb1.AppendFormat("6. Use potion(from inventory)\n");
                                sb1.AppendFormat("0. <--- Exit fight(with current HERO stats)\n");
                                sb1.AppendFormat("Use command: \n\n\n");
                                Console.WriteLine(sb1);

                                char cast = Console.ReadKey().KeyChar;

                                try
                                
                                {
                                    if (cast != '1' && cast != '2' && cast != '3' && cast != '4' && cast != '5' && cast != '6' && cast != '0')
                                    {
                                        throw new FormatException();
                                    }


                                    switch (cast)
                                    {
                                        case '1':
                                            hero.mobAttack(hero, monster, hero.WeaponGet.ItemValueGetSet);
                                            break;
                                        case '2':
                                            hero.castSpell(hero, monster, hero.SpellBookGet[0]);
                                            break;
                                        case '3':
                                            hero.castSpell(hero, monster, hero.SpellBookGet[1]);
                                            break;
                                        case '4':
                                            hero.castCombo(hero, monster, hero.SpellBookGet[0], hero.SpellBookGet[1]);
                                            break;
                                        case '5':
                                            if (hero.LevelGet >= 6)
                                            {
                                                hero.castSpell(hero, monster, hero.SpellBookGet[2]);
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nYou need level 6 to use the Ultimate ability\n\n\n\n");
                                                Console.ReadKey();
                                                continue;
                                            }
                                            break;
                                        case '6':
                                            askUsePotion(hero);
                                            continue;
                                        case '0':
                                            exit = true;
                                            break;
                                    }
                                    Console.WriteLine(monster.showMonsterFightStats());
                                    if (monster.HealthGetSet > 0)
                                    {
                                        monster.mobAttack(monster, hero, monster.DamageGet, stageNumber, replayGame);
                                        Console.WriteLine(hero.showHeroFightStats());
                                    }
                                    else if (hero.HealthGetSet < 0)
                                    {
                                        Console.WriteLine("\nStage failed!");
                                        Console.WriteLine("Press any key to continue...");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nStage completed!");
                                        Console.WriteLine("Press any key to continue...Stage {0}", stageNumber + 1);
                                        Console.ReadKey();
                                        completed = true;
                                        Console.Clear();
                                    }
                                }
                                catch (FormatException)
                                {

                                }
                            }
                            break;


                        case '2':
                            char buy;

                            do
                            {
                                StringBuilder sb2 = new StringBuilder();
                                sb2.AppendFormat("-----SHOP-----\n\n");
                                sb2.AppendFormat("1. Weapon(lvl 5+ needed) | Damage: {0} | 450 gold  (ON EVERY REPLAY YOU CAN BUY A MORE POWERFULL WEAPON!!!)\n", 200 * replayGame);
                                sb2.AppendFormat("2. Potion(health) | Health gain: {0} | 50 gold\n", 100 * replayGame);
                                sb2.AppendFormat("3. Potion(mana) | Mana gain: {0} | 50 gold\n", 150 * replayGame);
                                sb2.AppendFormat("4. Repair armor | 100 gold\n");
                                sb2.AppendFormat("5. Exit\n");
                                sb2.AppendFormat("Your GOLD: {0}\n", hero.GoldGetSet);
                                sb2.AppendFormat("Enter command: ");
                                Console.WriteLine(sb2);
                                buy = Console.ReadKey().KeyChar;

                                switch (buy)
                                {
                                    case '1':
                                        hero.buyItem(1, replayGame);
                                        Console.WriteLine("Press any key to continue...");
                                        Console.ReadKey();
                                        break;
                                    case '2':
                                        hero.buyItem(2, replayGame);
                                        Console.WriteLine("Press any key to continue...");
                                        Console.ReadKey();
                                        break;
                                    case '3':
                                        hero.buyItem(3, replayGame);
                                        Console.WriteLine("Press any key to continue...");
                                        Console.ReadKey();
                                        break;
                                    case '4':
                                        if (hero.GoldGetSet < 100)
                                        {
                                            Console.WriteLine("\nInsufficent gold!");
                                        }
                                        else
                                        {
                                            hero.ArmorGetSet = hero.ArmorCapGet;
                                            hero.GoldGetSet -= 100;
                                            Console.WriteLine("\nArmor repaired!");
                                        }
                                            break;
                                    case '5':
                                        break;
                                }
                            }while (buy != '5');
                            break;

                        case '3':
                            Console.WriteLine(hero.ToString());
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;

                        case '4':
                            hero.showInventory();
                            if (hero.InventoryGet.Count == 0)
                            {
                                Console.WriteLine("\nInventory empty!\n");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }
                            else
                            {
                                char use;

                                do
                                {
                                    Console.WriteLine("1. Equip weapon({0})", hero.countWeapons(new Item(Item.KindOfItem.Weapon, Item.KindOfWeapon.Axe)));
                                    Console.WriteLine("2. Use health potion({0}) -> power: +100 Health", hero.countHealthPotions(new Item(Item.KindOfItem.Potion, Item.KindOfPotion.Health)));
                                    Console.WriteLine("3. Use mana potion({0}) -> power +150 Mana", hero.countManaPotions(new Item(Item.KindOfItem.Potion, Item.KindOfPotion.Mana)));
                                    Console.WriteLine("4. Exit\n");
                                    Console.Write("Enter command: ");

                                    use = Console.ReadKey().KeyChar;

                                    switch (use)
                                    {
                                        case '1':
                                            hero.useItem(1);
                                            Console.WriteLine("\nNew weapon equiped!");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadKey();
                                            break;
                                        case '2':
                                            hero.useItem(2);
                                            Console.WriteLine("\nYou drinked health potion!");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadKey();
                                            break;
                                        case '3':
                                            hero.useItem(3);
                                            Console.WriteLine("\nYou drinked mana potion!");
                                            Console.WriteLine("Press any key to continue...");
                                            Console.ReadKey();
                                            break;
                                        case '4':
                                            break;
                                    }
                                }while (use != '4');
                            }
                            break;
                    }
                }
                catch(FormatException)
                {}
                



            } while (hero.HealthGetSet > 0 && completed == false);
        }
    }
}
