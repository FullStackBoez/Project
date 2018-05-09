using FroggerGame.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FroggerGame
{
    public partial class MainWindow : Form
    {
        private Frog frog;
        private WindowGrid windowGrid;
        private int defaultWindowWidth=800;
        private int defaultWindowHeight=600;
        private int defaultFrogWidth=40;
        private int defaultFrogHeight=40;
        private int defaultFrogSpeed=40;
        private int defaultFrogPosX=360;
        private int defaultFrogPosY=560;
        public static int numOfMoves = -2;
        private int pointsInGame = 0;
        private bool dead=false;
        private int double_points = 1;
        private int pointsAdder = 100;
        private int tickerPoints = 0;
        private int tickerInvincibility = 0;
        private int tickerDeadSafety = 0;


        public MainWindow()
        {
            frog = new Frog
                (defaultWindowHeight, defaultWindowWidth, defaultFrogHeight, defaultFrogWidth, defaultFrogPosX, defaultFrogPosY, defaultFrogSpeed, Properties.Resources.frogUp);
            windowGrid = new WindowGrid(defaultWindowHeight,defaultWindowWidth,defaultFrogHeight,defaultFrogWidth);
            
            InitializeComponent();
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            foreach(Lane ln in windowGrid.windowLanes)
            {
                e.Graphics.DrawImage(ln.laneBitmap, ln.laneRectangle);
                if (ln.powerup != null)
                {
                    e.Graphics.DrawImage(ln.powerup.image,ln.powerup.rectangle);
                }
                if (ln.rock != null)
                {
                    e.Graphics.DrawImage(ln.rock.image, ln.rock.rectangle);
                }
                if (ln.Type != 0)
                {
                    foreach (Box bo in ln.lineBox)
                    {
                        e.Graphics.DrawImage(bo.boxImage, bo.boxRectangle);
                    }
                }
            }
            e.Graphics.DrawImage(frog.boxImage, frog.boxRectangle);
        }

        private void tick(object sender, EventArgs e)
        {
            if (double_points==2) tickerPoints++;
            if (tickerPoints == 10)
            {
                double_points = 1;
                tickerPoints = 0;
            }
            if (frog.deadSafety && frog.isInvincible) tickerDeadSafety++;
            else if (frog.isInvincible) tickerInvincibility++;
            if (tickerInvincibility == 30)
            {
                frog.isInvincible = false;
                tickerInvincibility = 0;
            }
            if (tickerDeadSafety == 10)
            {
                frog.isInvincible = false;
                frog.deadSafety = false;
                tickerDeadSafety = 0;
            }
            foreach (Lane ln in windowGrid.windowLanes)
            {
                if (ln.powerup != null && frog.onPowerUp(ln.powerup))
                {
                    if (ln.powerup.power == Powers.EXTRA_LIFE) frog.lives++;
                    else if (ln.powerup.power == Powers.INVINCIBILITY) frog.isInvincible = true;
                    else if (ln.powerup.power == Powers.SUPER_JUMP) frog.jumps++;
                    else if (ln.powerup.power == Powers.DOUBLE_POINTS) double_points = 2;
                    ln.deletePowerUp();
                }
                if (ln.Type != 0)
                    foreach (Box bo in ln.lineBox)
                    {
                        bo.move();
                    }
            }
            if (!dead &&  windowGrid.crashed(frog)) Death();
            if (!dead && frog.dead) Death();
            extraJumps.Text = frog.jumps.ToString();
            lives.Text = frog.lives.ToString();
            timeInvincible.Text = tickerInvincibility.ToString();
            doublePoints.Text = tickerPoints.ToString();
            Invalidate();
        }

        // When a key is pressed the player moves.
        private void move(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                frog.moveUp();
                numOfMoves++;
            }
            if (e.KeyCode == Keys.Down)
            {
                frog.moveDown();
                if(numOfMoves>-2)
                numOfMoves--;
            }
            if (e.KeyCode == Keys.Left) frog.moveLeft();
            if (e.KeyCode == Keys.Right) frog.moveRight();
            if (e.KeyCode == Keys.Space)
            {
                frog.extraJump();
                numOfMoves += 2;
            }
            checkLine();
        }
        private void checkLine()
        {
            if (numOfMoves>=1)
            {
                pointsInGame += (pointsAdder*double_points);
                points.Text = pointsInGame.ToString();
                frog.moveDown();
                windowGrid.updateGrid();
                frog.boxImage = Properties.Resources.frogUp;
                Color col = frog.boxImage.GetPixel(1, 1);
                frog.boxImage.MakeTransparent(col);
                numOfMoves = 0;
            }
        }
        public void Death()
        {
            
            frog.boxImage = Properties.Resources.rip;
            Color col = frog.boxImage.GetPixel(1, 1);
            frog.boxImage.MakeTransparent(col);
            dead = true;

        
            DialogResult dr = MessageBox.Show("Do yo want to play again?", "Game over", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                Close();
            }
            else
            {
                dead = false;
                foreach (Lane l in windowGrid.windowLanes)
                {
                    l.Dispose();
                }
                points.Text = "0";
                pointsInGame = 0;
                numOfMoves = -2;
                frog.Dispose();
                frog = new Frog
                    (defaultWindowHeight, defaultWindowWidth, defaultFrogHeight, defaultFrogWidth, defaultFrogPosX, defaultFrogPosY, defaultFrogSpeed, Properties.Resources.frogUp);
                windowGrid = new WindowGrid(defaultWindowHeight, defaultWindowWidth, defaultFrogHeight, defaultFrogWidth);
            }
        }
    }
}
