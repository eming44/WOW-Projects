using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class Menu : UserControl
    {
        private Character hero =
                          new Character("",
                          new Hair(Hair.HairColor.Black, Hair.HairStyle.Medium),
                          new Eyes(Eyes.EyesColor.Red, Eyes.EyesOpen.Normal),
                          new BodyAndSkin(BodyAndSkin.SkinColor.Red, BodyAndSkin.BodyType.Muscular),
                          new FactionRaceGender(FactionRaceGender.HordeRaces.Orc, FactionRaceGender.Gender.Male),
                          new Classes(Classes.Class.Warrior, new FactionRaceGender(FactionRaceGender.HordeRaces.Orc)));
        public Character HeroGetSet
        {
            get
            {
                return this.hero;
            }
            set
            {
                this.hero = hero.becomeHero(value);
            }
        }
        public Menu()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (hero.UserNameGet == "Grommash Hellscream")
            {
                pictureBox1.Image = Properties.Resources.q3M6Mgw;
            }
        //    else if (hero.UserNameGet == "Lich King")
        //    {
        //        pictureBox1.Image = Properties.Resources.warcraft_lich_king_sword_armor_look_16238_1440x2560;
        //    }
        //    else if (hero.UserNameGet == "Sylvanas Windrunner")
        //    {
        //        pictureBox1.Image = Properties.Resources._5Hmuj9hjklleft;
        //    }
        //    else if (hero.UserNameGet == "Illidan Stormrage")
        //    {
        //        pictureBox1.Image = Properties.Resources.wow_legion_review_art_0_0;
        //    }
        //    else if (hero.UserNameGet == "Gul'dan")
        //    {
        //        pictureBox1.Image = Properties.Resources.Gul_dan__film_;
        //    }
        //    else if (hero.UserNameGet == "Anduin")
        //    {
        //        pictureBox1.Image = Properties.Resources.Anduin;
        //    }
        //    else if (hero.UserNameGet == "Thrall")
        //    {
        //        pictureBox1.Image = Properties.Resources._1410539_thrallCROP;
        //    }
        //    else if (hero.UserNameGet == "Valeera Sanguinar")
        //    {
        //        pictureBox1.Image = Properties.Resources._1__by_gothicq_dbkddtgSIZEre1;
        //    }
        //    else if (hero.UserNameGet == "Taran Zhu")
        //    {
        //        pictureBox1.Image = Properties.Resources._5_WOW_Taran_ZhuSIZEre;
        //    }
        //    else if (hero.UserNameGet == "Vindictor Maraad")
        //    {
        //        pictureBox1.Image = Properties.Resources.artwork_maraad1_large;
        //    }
        //    else if (hero.UserNameGet == "Malfurion Stormrage")
        //    {
        //        pictureBox1.Image = Properties.Resources.malfurion_stormrage_by_angju_d801qpzSIZE;
        //    }
        //    else if (hero.UserNameGet == "Arcmage Khadgar")
        //    {
        //        pictureBox1.Image = Properties.Resources.harbingers_story_of_khadgar_29_1920x816;
        //    }
        //    //Background image-----------------------
        //    if (hero.FactionRaceGenderGet.FactionGetSet.Equals(new FactionRaceGender(FactionRaceGender.AllianceRaces.Draenei).FactionGetSet))
        //    {
        //        BackgroundImage = Properties.Resources.allianceBackground;
        //    }
        //    else
        //    {
        //        BackgroundImage = Properties.Resources.hordeBackground;
        //    }
        //
        //    label1.Text = hero.UserNameGet;
        }


    }
}
