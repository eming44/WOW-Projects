using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Exercise1
{
    public partial class Form1 : Form
    {
        
        WindowsMediaPlayer audio = new WindowsMediaPlayer();
        WindowsMediaPlayer hoverAudio = new WindowsMediaPlayer();
        WindowsMediaPlayer clickAudio = new WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            //audio.URL = "c:/Users/Eming/Desktop/wowAudio.mp3";
            audio.URL = "wowAudio.mp3";
            hoverAudio.URL = "hoverAudio.mp3";
            clickAudio.URL = "clickAudio.mp3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            audio.controls.play();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
          //  playGame1.BringToFront();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
           pictureBox1.Image = Image.FromFile("c:/Users/Eming/Desktop/wowBOAgif.gif");
           // pictureBox1.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            clickAudio.controls.play();
            audio.controls.stop();
            heroes1.BringToFront();
        }


        private void bunifuImageButton2_Click(object sender, EventArgs e)
        { 
           if(audio.playState == WMPPlayState.wmppsPlaying)
           {
               audio.controls.stop();
           }
           else
           {
               audio.controls.play();
           }
        }
        //-----------------------------------------------------------------------------
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            try
            {
                clickAudio.controls.play();
                System.Diagnostics.Process.Start("https://www.blizzard.com/en-us/");
            }
            catch { }
        }

        
        private void bunifuImageButton3_MouseHover(object sender, EventArgs e)
        {
            hoverAudio.controls.play();
        }

        private void bunifuImageButton3_MouseLeave(object sender, EventArgs e)
        {
            hoverAudio.controls.stop();
        }
        //-------------------------------------------------------------------------------
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            try
            {
                clickAudio.controls.play();
                System.Diagnostics.Process.Start("https://us.battle.net/login/en/?ref=https://us.battle.net/account/management/&app=bam&cr=true");
            }
            catch { }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
