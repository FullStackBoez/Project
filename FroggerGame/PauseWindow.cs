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
  public enum STATE { RESUMED, NEW_GAME, QUIT}
    public partial class PauseWindow : Form
    {
        public STATE state;
        public PauseWindow()
        {
            InitializeComponent();
        }

        private void backToMenu(object sender, EventArgs e)
        {
            state = STATE.QUIT;
            Close();
        }

        private void newGame(object sender, EventArgs e)
        {
            state = STATE.NEW_GAME;
            Close();
        }

        private void resume(object sender, EventArgs e)
        {
            state = STATE.RESUMED;
            Close();
        }

        private void muteSong(object sender, EventArgs e)
        {
             
        }
    }
}
