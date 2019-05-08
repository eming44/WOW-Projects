using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wowAgain
{
    class Program
    {
        static void Main()
        {
            Character grommash = new Character(
                "Grommash Hellscream",
                new Hair(Hair.HairColor.Black, Hair.HairStyle.Medium),
                new Eyes(Eyes.EyesColor.Red, Eyes.EyesOpen.Normal),
                new BodyAndSkin(BodyAndSkin.SkinColor.Red, BodyAndSkin.BodyType.Muscular),
                new FactionRaceGender(FactionRaceGender.HordeRaces.Orc, FactionRaceGender.Gender.Male),
                new Classes(Classes.Class.Warrior, new FactionRaceGender(FactionRaceGender.HordeRaces.Orc)));
         
            Character anduin = new Character(
                "Anduin Wrynn",
                new Hair(Hair.HairColor.Blonde, Hair.HairStyle.Short),
                new Eyes(Eyes.EyesColor.Blue, Eyes.EyesOpen.Normal),
                new BodyAndSkin(BodyAndSkin.SkinColor.Medium, BodyAndSkin.BodyType.Muscular),
                new FactionRaceGender(FactionRaceGender.AllianceRaces.Human, FactionRaceGender.Gender.Male),
                new Classes(Classes.Class.Priest, new FactionRaceGender(FactionRaceGender.AllianceRaces.Human)));

            Character khadgar = new Character(
                "Arcmage Khadgar",
                new Hair(Hair.HairColor.White, Hair.HairStyle.Short),
                new Eyes(Eyes.EyesColor.Brown, Eyes.EyesOpen.Normal),
                new BodyAndSkin(BodyAndSkin.SkinColor.Medium, BodyAndSkin.BodyType.Muscular),
                new FactionRaceGender(FactionRaceGender.AllianceRaces.Human, FactionRaceGender.Gender.Male),
                new Classes(Classes.Class.Mage, new FactionRaceGender(FactionRaceGender.AllianceRaces.Human)));
       
            Character lichKing = new Character(
                "Lich King",
                new Hair(Hair.HairColor.White, Hair.HairStyle.Long),
                new Eyes(Eyes.EyesColor.Blue, Eyes.EyesOpen.Normal),
                new BodyAndSkin(BodyAndSkin.SkinColor.Light, BodyAndSkin.BodyType.Muscular),
                new FactionRaceGender(FactionRaceGender.AllianceRaces.Human, FactionRaceGender.Gender.Male),
                new Classes(Classes.Class.DeathKnight, new FactionRaceGender(FactionRaceGender.AllianceRaces.Human)));
       
            Character illidan = new Character(
                "Illidan Stormrage",
                new Hair(Hair.HairColor.Black, Hair.HairStyle.Long),
                new Eyes(Eyes.EyesColor.Green, Eyes.EyesOpen.Normal),
                new BodyAndSkin(BodyAndSkin.SkinColor.Purple, BodyAndSkin.BodyType.Muscular),
                new FactionRaceGender(FactionRaceGender.AllianceRaces.NightElf, FactionRaceGender.Gender.Male),
                new Classes(Classes.Class.DemonHunter, new FactionRaceGender(FactionRaceGender.AllianceRaces.NightElf)));
       
            Character sylvanas = new Character(
                "Sylvanas Windrunner",
                new Hair(Hair.HairColor.White, Hair.HairStyle.Short),
                new Eyes(Eyes.EyesColor.Red, Eyes.EyesOpen.Normal),
                new BodyAndSkin(BodyAndSkin.SkinColor.Purple, BodyAndSkin.BodyType.Slim),
                new FactionRaceGender(FactionRaceGender.HordeRaces.BloodElf, FactionRaceGender.Gender.Female),
                new Classes(Classes.Class.Hunter, new FactionRaceGender(FactionRaceGender.HordeRaces.BloodElf)));
       
            Character guldan = new Character(
                "Gul'dan",
                new Hair(Hair.HairColor.White, Hair.HairStyle.Medium),
                new Eyes(Eyes.EyesColor.Brown, Eyes.EyesOpen.Normal),
                new BodyAndSkin(BodyAndSkin.SkinColor.Green, BodyAndSkin.BodyType.Skinny),
                new FactionRaceGender(FactionRaceGender.HordeRaces.Orc, FactionRaceGender.Gender.Male),
                new Classes(Classes.Class.Warlock, new FactionRaceGender(FactionRaceGender.HordeRaces.Orc)));
       
            Character maraad = new Character(
                "Vindictor Maraad",
                new Hair(Hair.HairColor.Brunette, Hair.HairStyle.Short),
                new Eyes(Eyes.EyesColor.Brown, Eyes.EyesOpen.Normal),
                new BodyAndSkin(BodyAndSkin.SkinColor.Blue, BodyAndSkin.BodyType.Muscular),
                new FactionRaceGender(FactionRaceGender.AllianceRaces.Draenei, FactionRaceGender.Gender.Male),
                new Classes(Classes.Class.Paladin, new FactionRaceGender(FactionRaceGender.AllianceRaces.Draenei)));
           
              Character malfurion = new Character(
                  "Malfurion Stormrage",
                  new Hair(Hair.HairColor.White, Hair.HairStyle.Long),
                  new Eyes(Eyes.EyesColor.Brown, Eyes.EyesOpen.Normal),
                  new BodyAndSkin(BodyAndSkin.SkinColor.Pink, BodyAndSkin.BodyType.Muscular),
                  new FactionRaceGender(FactionRaceGender.HordeRaces.Undead, FactionRaceGender.Gender.Male),
                  new Classes(Classes.Class.Druid, new FactionRaceGender(FactionRaceGender.AllianceRaces.NightElf)));
           
              Character thrall = new Character(
                  "Thrall",
                  new Hair(Hair.HairColor.Black, Hair.HairStyle.Medium),
                  new Eyes(Eyes.EyesColor.Brown, Eyes.EyesOpen.Normal),
                  new BodyAndSkin(BodyAndSkin.SkinColor.Green, BodyAndSkin.BodyType.Muscular),
                  new FactionRaceGender(FactionRaceGender.HordeRaces.Orc, FactionRaceGender.Gender.Male),
                  new Classes(Classes.Class.Shaman, new FactionRaceGender(FactionRaceGender.HordeRaces.Orc)));
           
              Character valeera = new Character(
                  "Valeera Sanguinar",
                  new Hair(Hair.HairColor.Blonde, Hair.HairStyle.Long),
                  new Eyes(Eyes.EyesColor.Green, Eyes.EyesOpen.Normal),
                  new BodyAndSkin(BodyAndSkin.SkinColor.Medium, BodyAndSkin.BodyType.Slim),
                  new FactionRaceGender(FactionRaceGender.HordeRaces.BloodElf, FactionRaceGender.Gender.Female),
                  new Classes(Classes.Class.Rouge, new FactionRaceGender(FactionRaceGender.HordeRaces.BloodElf)));
           
              Character taran = new Character(
                  "Taran Zhu",
                  new Hair(Hair.HairColor.Black, Hair.HairStyle.Short),
                  new Eyes(Eyes.EyesColor.Brown, Eyes.EyesOpen.Normal),
                  new BodyAndSkin(BodyAndSkin.SkinColor.Dark, BodyAndSkin.BodyType.Fat),
                  new FactionRaceGender(FactionRaceGender.AllianceRaces.Pandaren, FactionRaceGender.Gender.Male),
                  new Classes(Classes.Class.Monk, new FactionRaceGender(FactionRaceGender.AllianceRaces.Pandaren)));

              StringBuilder sb = new StringBuilder();
              sb.AppendFormat("\n\t\t\t\t\tGAME RULES");
              sb.AppendFormat("\n\n\n1. Choose a class to play with, every class is represented by a hero in World of Warcraft.");
              sb.AppendFormat("\n----------------------------------------------------------------------------------------------");
              sb.AppendFormat("\n\n2. Every hero has health, mana, armor and damage.");
              sb.AppendFormat("\n----------------------------------------------------------------------------------------------");
              sb.AppendFormat("\nClasses: Mage, Warlock & Priest              -> higher MANA");
              sb.AppendFormat("\nClasses: Warrior, Paladin & Death Knight     -> higher ARMOR");
              sb.AppendFormat("\nClasses: Hunter, Demon hunter & Rogue        -> higher DAMAGE");
              sb.AppendFormat("\nClasses: Druid, Monk & Shaman                -> higher HEALTH");
              sb.AppendFormat("\n\n3. Every hero has 4 spells and basic attack.");
              sb.AppendFormat("\n----------------------------------------------------------------------------------------------");
              sb.AppendFormat("\nFirst 2 spells are unique for every class.\nThird spell is COMBO of the previous two(attack with both in one turn).\nFourth is the Ultimate ability(unlocks at level 6).\nThe basic attack deals damage equal to your waepon damage plus level bonus stats.");
              sb.AppendFormat("\nThere are 4 kind of spells:\nDamage       -> deals the damage.\nLife steal   -> deals damage and gives health that equals to the damage done.\nHeal         -> heales you(cannot exceed the health cap).\nArmor gain   -> give you more armor(can exceed the armor cap).");
              sb.AppendFormat("\n\n4. You can buy: weapons, potions and repair your armor when it's broken.");
              sb.AppendFormat("\n----------------------------------------------------------------------------------------------");
              sb.AppendFormat("\nThere are 4 types of armor: plate(strong), mail(medium strong), leather(medium) & cloth(low).");
              sb.AppendFormat("\nDifferent classes can wear different armot type:\nWarrior, Paladin & Death Knight   -> wear Plate armor\nHunter, Shaman & Druid            -> wear Mail armor\nDemon hunter, Rogue & Monk        -> wear Leather armor\nMage, Warlock & Priest            -> wear Cloth armor");
              sb.AppendFormat("\n\n5. With passing stages you gain gold and exp.");
              sb.AppendFormat("\n----------------------------------------------------------------------------------------------");
              sb.AppendFormat("\n\n6. At every level up your stats get higher.");
              sb.AppendFormat("\n----------------------------------------------------------------------------------------------");
              sb.AppendFormat("\n\n7. Fight the monsters and try to survive longer.");
              sb.AppendFormat("\n----------------------------------------------------------------------------------------------");
              sb.AppendFormat("\n\nPress any key to continue...");
              Console.WriteLine(sb);
              Console.ReadKey();
              Console.Clear();

              int command = 0;
              do
              {
                  Console.WriteLine("    Choose your champion:");
                  Console.WriteLine("------------------------------");
                  Console.WriteLine("1.(Mage)            -> Arcmage Khadgar");
                  Console.WriteLine("2.(Monk)            -> Taran Zhu");
                  Console.WriteLine("3.(Druid)           -> Malfurion Stormrage");
                  Console.WriteLine("4.(Rogue)           -> Valeera Sanguinar");
                  Console.WriteLine("5.(Priest)          -> Anduin Wrynn");
                  Console.WriteLine("6.(Hunter)          -> Sylvanas Windrunner");
                  Console.WriteLine("7.(Shaman)          -> Thrall");
                  Console.WriteLine("8.(Warlock)         -> Gul'dan");
                  Console.WriteLine("9.(Paladin)         -> Vindictor Maraadm");
                  Console.WriteLine("10.(Warrior)        -> Grommash Hellscream");
                  Console.WriteLine("11.(Death knight)   -> Lich King");
                  Console.WriteLine("12.(Demon hunter)   -> Illidan Stormrage");

                  Console.Write("\nEnter the number of hero you wanna play with: ");

                  try
                  {
                      command = int.Parse(Console.ReadLine());

                      if (command != 1 &&
                          command != 2 &&
                          command != 3 &&
                          command != 4 &&
                          command != 5 &&
                          command != 6 &&
                          command != 7 &&
                          command != 8 &&
                          command != 9 &&
                          command != 10 &&
                          command != 11 &&
                          command != 12)
                      {
                          throw new FormatException();
                      }

                      Character hero =
                          new Character("",
                          new Hair(Hair.HairColor.Black, Hair.HairStyle.Medium),
                          new Eyes(Eyes.EyesColor.Red, Eyes.EyesOpen.Normal),
                          new BodyAndSkin(BodyAndSkin.SkinColor.Red, BodyAndSkin.BodyType.Muscular),
                          new FactionRaceGender(FactionRaceGender.HordeRaces.Orc, FactionRaceGender.Gender.Male),
                          new Classes(Classes.Class.Warrior, new FactionRaceGender(FactionRaceGender.HordeRaces.Orc)));
                      switch (command)
                      {
                          case 1:
                              hero = hero.becomeHero(khadgar);
                              break;
                          case 2:
                              hero = hero.becomeHero(taran);
                              break;
                          case 3:
                              hero = hero.becomeHero(malfurion);
                              break;
                          case 4:
                              hero = hero.becomeHero(valeera);
                              break;
                          case 5:
                              hero = hero.becomeHero(anduin);
                              break;
                          case 6:
                              hero = hero.becomeHero(sylvanas);
                              break;
                          case 7:
                              hero = hero.becomeHero(thrall);
                              break;
                          case 8:
                              hero = hero.becomeHero(guldan);
                              break;
                          case 9:
                              hero = hero.becomeHero(maraad);
                              break;
                          case 10:
                              hero = hero.becomeHero(grommash);
                              break;
                          case 11:
                              hero = hero.becomeHero(lichKing);
                              break;
                          case 12:
                              hero = hero.becomeHero(illidan);
                              break;
                      }

                      int replay = 1;
                      Character monster1 = new Character("Kel'thuzad", 400, 100, 20);
                      Character monster2 = new Character("Sindragosa", 500, 150, 10);
                      Character monster3 = new Character("C'Thun", 600, 200, 29);
                      Character monster4 = new Character("Kael'Thas", 750, 250, 55);
                      Character monster5 = new Character("Deathwing", 850, 300, 88);
                      Character monster6 = new Character("Ragnaros the Firelord", 950, 350, 100);
                      Character monster7 = new Character("Garrosh", 1000, 450, 200);
                      Character monster8 = new Character("Odin", 2000, 500, 300);
                      Character monster9 = new Character("Kil'Jaeden", 2500, 550, 350);
                      Character monster10 = new Character("Sargeras", 4000, 600, 420);

                      Stage first = new Stage();
                      while (true)
                      {
                          first.fightStage(hero, monster1, 1, replay);
                          first.fightStage(hero, monster2, 2, replay);
                          first.fightStage(hero, monster3, 3, replay);
                          first.fightStage(hero, monster4, 4, replay);
                          first.fightStage(hero, monster5, 5, replay);
                          first.fightStage(hero, monster6, 6, replay);
                          first.fightStage(hero, monster7, 7, replay);
                          first.fightStage(hero, monster8, 8, replay);
                          first.fightStage(hero, monster9, 9, replay);
                          first.fightStage(hero, monster10, 10, replay);

                          replay++;

                          monster1.levelUpStage();
                          monster2.levelUpStage();
                          monster3.levelUpStage();
                          monster4.levelUpStage();
                          monster5.levelUpStage();
                          monster6.levelUpStage();
                          monster7.levelUpStage();
                          monster8.levelUpStage();
                          monster9.levelUpStage();
                          monster10.levelUpStage();
                      }

                  }

                  catch (FormatException)
                  {
                      Console.WriteLine("Invalid command, try again...");
                      Console.ReadKey();
                      Console.Clear();
                  }
              } while (command != 1 &&
                      command != 2 &&
                      command != 3 &&
                      command != 4 &&
                      command != 5 &&
                      command != 6 &&
                      command != 7 &&
                      command != 8 &&
                      command != 9 &&
                      command != 10 &&
                      command != 11 &&
                      command != 12);

         // TEST......................................................................................................................
         //   for (int i = 0; i < 10; i++)
         //   {
         //       grommash.castCombo(grommash, monster, new Spells(Spells.Warrior.Execute), new Spells(Spells.Warrior.HeroicStrike));
         //       anduin.castCombo(anduin, monster, new Spells(Spells.PriestSpells.Heal), new Spells(Spells.PriestSpells.Smite));
         //       khadgar.castCombo(khadgar, monster, new Spells(Spells.MageSpells.PyroBlast), new Spells(Spells.MageSpells.FireBall));
         //       lichKing.castCombo(lichKing, monster, new Spells(Spells.DeathKnightSpells.Lifesteal), new Spells(Spells.DeathKnightSpells.DeathStrike));
         //       illidan.castCombo(illidan, monster, new Spells(Spells.DemonHunter.DemonSkin), new Spells(Spells.DemonHunter.DoubleSlash));
         //       sylvanas.castCombo(sylvanas, monster, new Spells(Spells.Hunter.FireTrap), new Spells(Spells.Hunter.ChimeraShot));
         //       guldan.castCombo(guldan, monster, new Spells(Spells.Warlock.DrainLife), new Spells(Spells.Warlock.ChaosBolt));
         //       maraad.castCombo(maraad, monster, new Spells(Spells.Paladin.DivineShild), new Spells(Spells.Paladin.Judgment));
         //       malfurion.castCombo(malfurion, monster, new Spells(Spells.Druid.Swipe), new Spells(Spells.Druid.Regrowth));
         //       thrall.castCombo(thrall, monster, new Spells(Spells.Shaman.LavaBurst), new Spells(Spells.Shaman.LightningBolt));
         //       valeera.castCombo(valeera, monster, new Spells(Spells.Rogue.Eviscerate), new Spells(Spells.Rogue.Backstab));
         //       taran.castCombo(taran, monster, new Spells(Spells.Monk.FlyingSerpentKick), new Spells(Spells.Monk.BlackoutKick));
         //   }
         //
         //   Console.WriteLine(grommash.ToString());
         //   Console.WriteLine(anduin.ToString());
         //   Console.WriteLine(khadgar.ToString());
         //   Console.WriteLine(lichKing.ToString());
         //   Console.WriteLine(illidan.ToString());
         //   Console.WriteLine(sylvanas.ToString());
         //   Console.WriteLine(guldan.ToString());
         //   Console.WriteLine(maraad.ToString());
         //   Console.WriteLine(malfurion.ToString());
         //   Console.WriteLine(thrall.ToString());
         //   Console.WriteLine(valeera.ToString());
         //   Console.WriteLine(taran.ToString()); 2605
        }
    }
}
