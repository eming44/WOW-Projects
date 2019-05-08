namespace Exercise1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.exitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.enterWorldBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.playStopAudioBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.blizzardBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.battleNetBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gameRules1 = new Exercise1.gameRules();
            this.heroes1 = new Exercise1.Heroes();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playStopAudioBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blizzardBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.battleNetBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 33);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(37, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "World of warcraft";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Exercise1.Properties.Resources.World_of_warcraft_icon;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Image = global::Exercise1.Properties.Resources.close_icon;
            this.exitBtn.ImageActive = null;
            this.exitBtn.Location = new System.Drawing.Point(1222, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(28, 26);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitBtn.TabIndex = 0;
            this.exitBtn.TabStop = false;
            this.exitBtn.Zoom = 10;
            this.exitBtn.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            this.exitBtn.MouseHover += new System.EventHandler(this.bunifuImageButton3_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Exercise1.Properties.Resources.wowBOAgif2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1262, 753);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // enterWorldBtn
            // 
            this.enterWorldBtn.Activecolor = System.Drawing.Color.Transparent;
            this.enterWorldBtn.BackColor = System.Drawing.Color.Transparent;
            this.enterWorldBtn.BackgroundImage = global::Exercise1.Properties.Resources.Buttons_PNG_Image_21290;
            this.enterWorldBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.enterWorldBtn.BorderRadius = 0;
            this.enterWorldBtn.ButtonText = "Enter world";
            this.enterWorldBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterWorldBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.enterWorldBtn.Iconimage = null;
            this.enterWorldBtn.Iconimage_right = null;
            this.enterWorldBtn.Iconimage_right_Selected = null;
            this.enterWorldBtn.Iconimage_Selected = null;
            this.enterWorldBtn.IconZoom = 90D;
            this.enterWorldBtn.IsTab = false;
            this.enterWorldBtn.Location = new System.Drawing.Point(495, 463);
            this.enterWorldBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enterWorldBtn.Name = "enterWorldBtn";
            this.enterWorldBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.enterWorldBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.enterWorldBtn.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.enterWorldBtn.selected = false;
            this.enterWorldBtn.Size = new System.Drawing.Size(280, 142);
            this.enterWorldBtn.TabIndex = 4;
            this.enterWorldBtn.Textcolor = System.Drawing.Color.White;
            this.enterWorldBtn.TextFont = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterWorldBtn.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            this.enterWorldBtn.MouseLeave += new System.EventHandler(this.bunifuImageButton3_MouseLeave);
            this.enterWorldBtn.MouseHover += new System.EventHandler(this.bunifuImageButton3_MouseHover);
            // 
            // playStopAudioBtn
            // 
            this.playStopAudioBtn.BackColor = System.Drawing.Color.Transparent;
            this.playStopAudioBtn.Image = global::Exercise1.Properties.Resources._4bb529b08c31f15a380d80fd6fdc5b74;
            this.playStopAudioBtn.ImageActive = null;
            this.playStopAudioBtn.Location = new System.Drawing.Point(111, 703);
            this.playStopAudioBtn.Name = "playStopAudioBtn";
            this.playStopAudioBtn.Size = new System.Drawing.Size(39, 30);
            this.playStopAudioBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playStopAudioBtn.TabIndex = 5;
            this.playStopAudioBtn.TabStop = false;
            this.playStopAudioBtn.Zoom = 10;
            this.playStopAudioBtn.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            this.playStopAudioBtn.MouseLeave += new System.EventHandler(this.bunifuImageButton3_MouseLeave);
            this.playStopAudioBtn.MouseHover += new System.EventHandler(this.bunifuImageButton3_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.BurlyWood;
            this.label2.Location = new System.Drawing.Point(154, 710);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Disable Login Music";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // blizzardBtn
            // 
            this.blizzardBtn.BackColor = System.Drawing.Color.Transparent;
            this.blizzardBtn.Image = global::Exercise1.Properties.Resources.Blizzard_Entertainment_Logo_svg;
            this.blizzardBtn.ImageActive = null;
            this.blizzardBtn.Location = new System.Drawing.Point(12, 39);
            this.blizzardBtn.Name = "blizzardBtn";
            this.blizzardBtn.Size = new System.Drawing.Size(127, 71);
            this.blizzardBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blizzardBtn.TabIndex = 8;
            this.blizzardBtn.TabStop = false;
            this.blizzardBtn.Zoom = 10;
            this.blizzardBtn.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            this.blizzardBtn.MouseLeave += new System.EventHandler(this.bunifuImageButton3_MouseLeave);
            this.blizzardBtn.MouseHover += new System.EventHandler(this.bunifuImageButton3_MouseHover);
            // 
            // battleNetBtn
            // 
            this.battleNetBtn.BackColor = System.Drawing.Color.Transparent;
            this.battleNetBtn.Image = global::Exercise1.Properties.Resources.battle_net;
            this.battleNetBtn.ImageActive = null;
            this.battleNetBtn.Location = new System.Drawing.Point(12, 670);
            this.battleNetBtn.Name = "battleNetBtn";
            this.battleNetBtn.Size = new System.Drawing.Size(71, 71);
            this.battleNetBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.battleNetBtn.TabIndex = 9;
            this.battleNetBtn.TabStop = false;
            this.battleNetBtn.Zoom = 10;
            this.battleNetBtn.Click += new System.EventHandler(this.bunifuImageButton2_Click_1);
            this.battleNetBtn.MouseLeave += new System.EventHandler(this.bunifuImageButton3_MouseLeave);
            this.battleNetBtn.MouseHover += new System.EventHandler(this.bunifuImageButton3_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(89, 668);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 73);
            this.panel2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Moccasin;
            this.label3.Location = new System.Drawing.Point(1114, 724);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Version 9.3.2.25549.";
            // 
            // gameRules1
            // 
            this.gameRules1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameRules1.BackgroundImage")));
            this.gameRules1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gameRules1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameRules1.Location = new System.Drawing.Point(0, 0);
            this.gameRules1.Name = "gameRules1";
            this.gameRules1.Size = new System.Drawing.Size(1262, 753);
            this.gameRules1.TabIndex = 12;
            // 
            // heroes1
            // 
            this.heroes1.BackColor = System.Drawing.Color.Black;
            this.heroes1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("heroes1.BackgroundImage")));
            this.heroes1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heroes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroes1.Location = new System.Drawing.Point(0, 0);
            this.heroes1.Name = "heroes1";
            this.heroes1.Size = new System.Drawing.Size(1262, 753);
            this.heroes1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Exercise1.Properties.Resources.wowBOAgif2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.enterWorldBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.battleNetBtn);
            this.Controls.Add(this.blizzardBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playStopAudioBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gameRules1);
            this.Controls.Add(this.heroes1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playStopAudioBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blizzardBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.battleNetBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton exitBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton enterWorldBtn;
        private Bunifu.Framework.UI.BunifuImageButton playStopAudioBtn;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton blizzardBtn;
        private Bunifu.Framework.UI.BunifuImageButton battleNetBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private gameRules gameRules1;
        private Heroes heroes1;


    }
}

