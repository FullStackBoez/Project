namespace FroggerGame
{
    partial class MenuWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuWindow));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.newgame = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.newgame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "NEW GAME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.New_Game);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(235, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "INSTRUCTIONS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Instructions);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(235, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "EXIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Exit);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // newgame
            // 
            this.newgame.BackgroundImage = global::FroggerGame.Properties.Resources.wallpaper;
            this.newgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newgame.Controls.Add(this.button9);
            this.newgame.Controls.Add(this.name);
            this.newgame.Controls.Add(this.label5);
            this.newgame.Controls.Add(this.button8);
            this.newgame.Controls.Add(this.button7);
            this.newgame.Controls.Add(this.button6);
            this.newgame.Controls.Add(this.button5);
            this.newgame.Controls.Add(this.button4);
            this.newgame.Controls.Add(this.label4);
            this.newgame.Controls.Add(this.label3);
            this.newgame.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.newgame.Dock = System.Windows.Forms.DockStyle.Left;
            this.newgame.Location = new System.Drawing.Point(0, 0);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(784, 561);
            this.newgame.TabIndex = 15;
            this.newgame.Visible = false;
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::FroggerGame.Properties.Resources.unmute;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Location = new System.Drawing.Point(672, 14);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 66);
            this.button9.TabIndex = 9;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.muteSong);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 73);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(198, 20);
            this.name.TabIndex = 8;
            this.name.Validating += new System.ComponentModel.CancelEventHandler(this.name_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name: ";
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::FroggerGame.Properties.Resources.back;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Location = new System.Drawing.Point(45, 487);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 42);
            this.button8.TabIndex = 6;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.back);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::FroggerGame.Properties.Resources.red;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(9, 295);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(205, 41);
            this.button7.TabIndex = 5;
            this.button7.Text = "HARD";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.hard);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::FroggerGame.Properties.Resources.yellow;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(9, 229);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(205, 44);
            this.button6.TabIndex = 4;
            this.button6.Text = "MEDIUM";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.medium);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::FroggerGame.Properties.Resources.menuitem;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(9, 162);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(205, 45);
            this.button5.TabIndex = 3;
            this.button5.Text = "EASY";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.easy);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::FroggerGame.Properties.Resources.grass;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(585, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 48);
            this.button4.TabIndex = 2;
            this.button4.Text = "LEARN";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.bootcamp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "TOURNAMENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(619, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "BOOTCAMP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 164);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mute
            // 
            this.mute.BackgroundImage = global::FroggerGame.Properties.Resources.unmute;
            this.mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mute.Location = new System.Drawing.Point(667, 12);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(89, 68);
            this.mute.TabIndex = 11;
            this.mute.UseVisualStyleBackColor = true;
            this.mute.Click += new System.EventHandler(this.muteSong);
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mute);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MenuWindow";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.newgame.ResumeLayout(false);
            this.newgame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button mute;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel newgame;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}