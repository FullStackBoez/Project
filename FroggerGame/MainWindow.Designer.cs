namespace FroggerGame
{
    partial class MainWindow
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lives = new System.Windows.Forms.Label();
            this.extraJumps = new System.Windows.Forms.Label();
            this.timeInvincible = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.doublePoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 599);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(820, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(295, 607);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "INV";
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.points.Location = new System.Drawing.Point(436, 609);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(0, 20);
            this.points.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 607);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "LIVES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(119, 607);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "EXTRA JUMP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(361, 607);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "POINTS";
            // 
            // lives
            // 
            this.lives.AutoSize = true;
            this.lives.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lives.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lives.Location = new System.Drawing.Point(76, 607);
            this.lives.Name = "lives";
            this.lives.Size = new System.Drawing.Size(2, 22);
            this.lives.TabIndex = 8;
            // 
            // extraJumps
            // 
            this.extraJumps.AutoSize = true;
            this.extraJumps.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.extraJumps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extraJumps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraJumps.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.extraJumps.Location = new System.Drawing.Point(237, 607);
            this.extraJumps.Name = "extraJumps";
            this.extraJumps.Size = new System.Drawing.Size(2, 22);
            this.extraJumps.TabIndex = 9;
            // 
            // timeInvincible
            // 
            this.timeInvincible.AutoSize = true;
            this.timeInvincible.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.timeInvincible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeInvincible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeInvincible.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.timeInvincible.Location = new System.Drawing.Point(339, 607);
            this.timeInvincible.Name = "timeInvincible";
            this.timeInvincible.Size = new System.Drawing.Size(2, 22);
            this.timeInvincible.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(483, 607);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "DOUBLE";
            // 
            // doublePoints
            // 
            this.doublePoints.AutoSize = true;
            this.doublePoints.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.doublePoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.doublePoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doublePoints.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.doublePoints.Location = new System.Drawing.Point(567, 609);
            this.doublePoints.Name = "doublePoints";
            this.doublePoints.Size = new System.Drawing.Size(2, 22);
            this.doublePoints.TabIndex = 12;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 641);
            this.Controls.Add(this.doublePoints);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timeInvincible);
            this.Controls.Add(this.extraJumps);
            this.Controls.Add(this.lives);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.points);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(820, 680);
            this.MinimumSize = new System.Drawing.Size(820, 680);
            this.Name = "MainWindow";
            this.Text = "Frogger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Draw);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.move);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lives;
        private System.Windows.Forms.Label extraJumps;
        private System.Windows.Forms.Label timeInvincible;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label doublePoints;
    }
}

