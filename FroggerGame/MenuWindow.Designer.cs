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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newgame = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.newgame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 76);
            this.label1.TabIndex = 3;
            this.label1.Text = "FROGGER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(514, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pro designer";
            // 
            // newgame
            // 
            this.newgame.Controls.Add(this.name);
            this.newgame.Controls.Add(this.label5);
            this.newgame.Controls.Add(this.button8);
            this.newgame.Controls.Add(this.button7);
            this.newgame.Controls.Add(this.button6);
            this.newgame.Controls.Add(this.button5);
            this.newgame.Controls.Add(this.button4);
            this.newgame.Controls.Add(this.label4);
            this.newgame.Controls.Add(this.label3);
            this.newgame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newgame.Location = new System.Drawing.Point(0, 0);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(784, 561);
            this.newgame.TabIndex = 5;
            this.newgame.Visible = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(274, 303);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(244, 33);
            this.button7.TabIndex = 5;
            this.button7.Text = "HARD";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.hard);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(274, 256);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(244, 33);
            this.button6.TabIndex = 4;
            this.button6.Text = "MEDIUM";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.medium);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(274, 211);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(244, 33);
            this.button5.TabIndex = 3;
            this.button5.Text = "EASY";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.easy);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(274, 389);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(244, 33);
            this.button4.TabIndex = 2;
            this.button4.Text = "LEARN";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.bootcamp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "TOURAMENT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(349, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "BOOTCAMP";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(25, 498);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 31);
            this.button8.TabIndex = 6;
            this.button8.Text = "BACK";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.back);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name: ";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(320, 107);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(198, 20);
            this.name.TabIndex = 8;
            this.name.Validating += new System.ComponentModel.CancelEventHandler(this.validate);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MenuWindow";
            this.Text = "Menu";
            this.newgame.ResumeLayout(false);
            this.newgame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel newgame;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}