using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FroggerGame
{
    public partial class MenuWindow : Form
    {
        private string name1;
        public static bool isMusicOn = true;
        public static SoundPlayer sp;
        public int par = 0;
        
        public MenuWindow()
        {

            this.BackColor = Color.Beige;
            sp = new SoundPlayer(Properties.Resources.menuSong);
            sp.PlayLooping();
            
            InitializeComponent();

            

            
        }

        private void Exit(object sender, EventArgs e)
        {
            Close();
        }

        private void New_Game(object sender, EventArgs e)
        {
            newgame.Visible = true;
            name.Text = null;
        }

        private void Instructions(object sender, EventArgs e)
        {
            InstructionsWindow ins = new InstructionsWindow();
            ins.ShowDialog();
        }

        private void easy(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                this.Visible = false;
                MainWindow mw = new MainWindow(DIFICULTY.TOURNAMENT_EASY, name1);
                mw.ShowDialog();
                this.Visible = true;
                mw.Dispose();
            }
        }

        private void medium(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                this.Visible = false;
                MainWindow mw = new MainWindow(DIFICULTY.TOURNAMENT_MEDIUM, name1);
                mw.ShowDialog();
                this.Visible = true;
                mw.Dispose();
            }
        }

        private void hard(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                this.Visible = false;
                MainWindow mw = new MainWindow(DIFICULTY.TOURNAMENT_HARD, name1);
                mw.ShowDialog();
                this.Visible = true;
                mw.Dispose();
            }
        }

        private void bootcamp(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                this.Visible = false;
                MainWindow mw = new MainWindow(DIFICULTY.NOVICE, name1);
                mw.ShowDialog();
                this.Visible = true;
                mw.Dispose();
            }
        }

        private void back(object sender, EventArgs e)
        {
            name.Text = "filler";
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                newgame.Visible = false;
            }

        }

        private void validate(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text))
            {
                e.Cancel = true;
                name.Focus();
                errorProvider1.SetError(name, "Please enter your name");
            }
            else
            {
                name1 = name.Text;
                e.Cancel = false;
                errorProvider1.SetError(name, null);
            }
        }

        private void muteSong(object sender, EventArgs e)
        {
            par++;
            if (par % 2 == 0)
            {
                button9.BackgroundImage = Properties.Resources.unmute;
                mute.BackgroundImage = Properties.Resources.unmute;
            }
            else
            {
                button9.BackgroundImage = Properties.Resources.mute;
                mute.BackgroundImage = Properties.Resources.mute;
            }

            if (isMusicOn)
            {
                

                sp.Stop();
                isMusicOn = false;
            }
            else
            {
                sp.PlayLooping();
                isMusicOn = true;
                
            }
            
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text)) name.Text = "filler";
        }

        private void newgame_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text))
            {

                errorProvider1.SetError(name, "Внесете име");
                e.Cancel = true;
            }
            else
                errorProvider1.SetError(name, "");


        }

        private void newgame_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
            
               
        }

        private void name_TextChanged_1(object sender, EventArgs e)
        {

        }

        
        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
