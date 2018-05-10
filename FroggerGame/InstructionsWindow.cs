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
    public partial class InstructionsWindow : Form
    {
        public InstructionsWindow()
        {
            InitializeComponent();
        }

        private void GotoTODO(object sender, EventArgs e)
        {
            whatToDO.Visible = true;
        }

        private void BacktoHOWTODO(object sender, EventArgs e)
        {
            whatToDO.Visible = false;
        }

        private void GotoGOAL(object sender, EventArgs e)
        {
            goal.Visible = true;
        }

        private void DONE(object sender, EventArgs e)
        {
            Close();
        }

        private void BacktoTODO(object sender, EventArgs e)
        {
            whatToDO.Visible = true;
            goal.Visible = false;
        }
    }
}
