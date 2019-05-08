using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Exercise1
{
    public partial class Heroes : UserControl
    {
        WindowsMediaPlayer hoverAudio = new WindowsMediaPlayer();
        WindowsMediaPlayer clickAudio = new WindowsMediaPlayer();

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
            new FactionRaceGender(FactionRaceGender.HordeRaces.Pandaren, FactionRaceGender.Gender.Male),
            new Classes(Classes.Class.Monk, new FactionRaceGender(FactionRaceGender.AllianceRaces.Pandaren)));
        //------------------------------------------------------------------------------------------------------------------
        
        public Heroes()
        {
            InitializeComponent();
            hoverAudio.URL = "hoverAudio.mp3";
            clickAudio.URL = "clickAudio.mp3";
        }


        //-------------------------------------------------------------------------------------


        private void bunifuImageButton1_MouseHover(object sender, EventArgs e)
        {
            hoverAudio.controls.play();
        }

        private void bunifuImageButton1_MouseLeave(object sender, EventArgs e)
        {
            hoverAudio.controls.stop();
        }
        //------------------------------------------------------------------------------------------

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            clickAudio.controls.play();
           // menu1.HeroGetSet = sylvanas;
           // menu1.Visible = true;

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            clickAudio.controls.play();
            //menu1.BringToFront();
         //   menu1.HeroGetSet = grommash;
           // menu1.Visible = true;
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            clickAudio.controls.play();
          //  menu1.HeroGetSet = maraad;
           // menu1.Visible = true;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            clickAudio.controls.play();
           // menu1.HeroGetSet = lichKing;
           // menu1.Visible = true;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            clickAudio.controls.play();
          //  menu1.HeroGetSet = illidan;
           // menu1.Visible = true;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            clickAudio.controls.play();
          //  menu1.HeroGetSet = guldan;
          //  menu1.Visible = true;
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            clickAudio.controls.play();
          //  menu1.HeroGetSet = anduin;
           // menu1.Visible = true;
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            clickAudio.controls.play();
          //  menu1.HeroGetSet = thrall;
          //  menu1.Visible = true;
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            clickAudio.controls.play();
         //   menu1.HeroGetSet = valeera;
           // menu1.Visible = true;
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            clickAudio.controls.play();
         //   menu1.HeroGetSet = taran;
          //  menu1.Visible = true;
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            clickAudio.controls.play();
        //    menu1.HeroGetSet = malfurion;
          //  menu1.Visible = true;
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            clickAudio.controls.play();
          //  menu1.HeroGetSet = khadgar;
           // menu1.Visible = true;
        }

        private void menu1_Load(object sender, EventArgs e)
        {

        }
    }
}
