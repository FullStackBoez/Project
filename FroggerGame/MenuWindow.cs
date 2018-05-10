using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FroggerGame
{
    public partial class MenuWindow : Form
    {
        private string name1;
        public MenuWindow()
        {
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
                MainWindow mw = new MainWindow(DIFICULTY.TOURNAMENT_EASY,name1);
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
    }
}
